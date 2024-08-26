import json
import logging
import os
import pyodbc

# Configure logging to write to a log file and output to console
logging.basicConfig(
    level=logging.DEBUG,
    format="%(asctime)s - %(levelname)s - %(message)s",
    handlers=[logging.FileHandler("retrieve_metadata.log"), logging.StreamHandler()],
)


def load_config(config_file):
    """Load configuration from a JSON file."""
    try:
        with open(config_file, "r") as file:
            config = json.load(file)
            logging.info(f"Loaded configuration from {config_file}")
            return config
    except FileNotFoundError as e:
        logging.error(f"Configuration file not found: {e}")
        raise
    except json.JSONDecodeError as e:
        logging.error(f"Error decoding JSON configuration: {e}")
        raise


def get_csharp_type(sql_type):
    """Map SQL data types to C# data types."""
    type_mapping = {
        "image": "byte[]",
        "money": "decimal",
        "int": "int",
        "decimal": "decimal",
        "timestamp": "byte[]",
        "varbinary": "byte[]",
        "text": "string",
        "smallint": "short",
        "varchar": "string",
        "datetime": "DateTime",
        "uniqueidentifier": "Guid",
        "tinyint": "byte",
        "nchar": "string",
        "smalldatetime": "DateTime",
        "float": "double",
        "date": "DateTime",
        "char": "string",
        "bigint": "long",
        "nvarchar": "string",
        "sysname": "string",
        "bit": "bool",
        "str": "string",  # Added mapping from str to string
    }
    return type_mapping.get(str(sql_type).lower(), "object")


def parse_sql_type(sql_type, length):
    """Parse SQL type to extract the type and size."""
    if isinstance(sql_type, str):
        return sql_type, length
    return sql_type, None


def get_dummy_value(sql_type):
    """Return a dummy value based on the SQL type."""
    dummy_values = {
        "int": 0,
        "bigint": 0,
        "smallint": 0,
        "tinyint": 0,
        "bit": 0,
        "decimal": 0.0,
        "numeric": 0.0,
        "money": 0.0,
        "float": 0.0,
        "real": 0.0,
        "datetime": "'2022-01-01'",
        "smalldatetime": "'2022-01-01'",
        "date": "'2022-01-01'",
        "time": "'00:00:00'",
        "char": "'a'",
        "nchar": "'a'",
        "varchar": "'a'",
        "nvarchar": "'a'",
        "text": "'a'",
        "ntext": "'a'",
        "binary": "0x0",
        "varbinary": "0x0",
        "image": "0x0",
        "uniqueidentifier": "'00000000-0000-0000-0000-000000000000'",
    }
    return dummy_values.get(str(sql_type).lower(), "'a'")

def get_stored_procedure_metadata(cursor, stored_procedure_name):
    """Get metadata for a stored procedure from the SQL Server."""
    try:
        logging.info(f"Retrieving metadata for stored procedure: {stored_procedure_name}")

        cursor.execute(f"sp_sproc_columns '{stored_procedure_name}'")
        parameters = cursor.fetchall()

        if not parameters:
            logging.warning(f"No metadata found for stored procedure: {stored_procedure_name}")
            return [], "void", []  # Return empty parameter list, 'void' as scalar type, and empty result set

        param_info = []
        param_values = []
        scalar_type = "void"
        result_set = []
        
        for param in parameters:
            sql_type, size = parse_sql_type(param[6], param[8])
            logging.info(f"Parameter: {param[3]}, SQL Type: {sql_type}, Size: {size}, Direction: {param[4]}")
            param_info.append({
                "Name": param[3],  # COLUMN_NAME
                "Type": sql_type,
                "Size": size,
                "Direction": param[4],  # PARAMETER_TYPE (1: Input, 2: Output, 4: Return)
            })
            if param[4] == 1:  # Input parameter
                param_values.append(get_dummy_value(sql_type))
            elif param[4] == 4 or param[3] == "@RETURN_VALUE":  # Return value
                scalar_type = get_csharp_type(sql_type)
            else:
                param_values.append(None)  # Placeholder for non-input parameters

        # Filter out the return value parameter from param_info
        param_info = [param for param in param_info if param["Name"] != "@RETURN_VALUE"]

        # Generate the EXEC statement with dummy values, excluding the return value parameter
        exec_statement = f"EXEC {stored_procedure_name} " + ", ".join(
            f"{param['Name']}={value}"
            for param, value in zip(param_info, param_values)
            if param["Direction"] == 1 and value is not None
        )
        logging.info(f"Generated SQL: {exec_statement}")

        # Execute the stored procedure to get columns in the result set
        try:
            cursor.execute(exec_statement)
            columns = cursor.description
            if columns:
                for col in columns:
                    col_name = col[0]
                    sql_type_class = col[1]  # Extract the SQL type class
                    sql_type_name = sql_type_class.__name__  # Extract the type name
                    csharp_type = get_csharp_type(sql_type_name)  # Map to C# type
                    result_set.append({
                        "Name": col_name,
                        "SqlType": sql_type_name,  # Include SQL type in JSON
                        "CSharpType": csharp_type  # Include C# type in JSON
                    })

        except pyodbc.Error as e:
            logging.warning(f"Error executing stored procedure for return type inference: {e}")
            # Maintain existing result_set

        logging.info(f"Metadata for {stored_procedure_name}: Parameters: {param_info}, Scalar: {scalar_type}, ResultSet: {result_set}")
        return param_info, scalar_type, result_set

    except pyodbc.Error as e:
        logging.error(f"Error retrieving metadata for stored procedure {stored_procedure_name}: {e}")
        raise



def create_new_connection(connection_string):
    """Create a new connection to SQL Server."""
    return pyodbc.connect(connection_string)


def update_json_with_metadata(json_file, connection_string):
    """Update the JSON file with metadata from SQL Server."""
    try:
        with open(json_file, "r") as file:
            data = json.load(file)
            logging.info(f"Loaded configuration from {json_file}")
    except FileNotFoundError as e:
        logging.error(f"Configuration file not found: {e}")
        raise
    except json.JSONDecodeError as e:
        logging.error(f"Error decoding JSON configuration: {e}")
        raise

    try:
        conn = create_new_connection(connection_string)
        cursor = conn.cursor()
        logging.info(f"Connected to SQL Server")

        for namespace in data["Namespaces"]:
            for obj in namespace["Objects"]:
                for sp in obj["StoredProcedures"]:
                    stored_procedure_name = sp["StoredProcedureName"]
                    logging.info(
                        f"Processing stored procedure: {stored_procedure_name}"
                    )
                    try:
                        param_info, scalar_type, result_set = (
                            get_stored_procedure_metadata(cursor, stored_procedure_name)
                        )
                        sp["Parameters"] = param_info
                        sp["Scalar"] = scalar_type
                        sp["ResultSet"] = result_set
                        logging.info(
                            f"Processed stored procedure: {stored_procedure_name} with Scalar type {scalar_type} and ResultSet {result_set}"
                        )
                    except pyodbc.Error as e:
                        logging.error(
                            f"Error processing stored procedure {stored_procedure_name}: {e}"
                        )
                        # Create a new connection and retry once
                        conn.close()
                        conn = create_new_connection(connection_string)
                        cursor = conn.cursor()
                        try:
                            param_info, scalar_type, result_set = (
                                get_stored_procedure_metadata(
                                    cursor, stored_procedure_name
                                )
                            )
                            sp["Parameters"] = param_info
                            sp["Scalar"] = scalar_type
                            sp["ResultSet"] = result_set
                            logging.info(
                                f"Processed stored procedure after retry: {stored_procedure_name} with Scalar type {scalar_type} and ResultSet {result_set}"
                            )
                        except pyodbc.Error as retry_e:
                            logging.error(
                                f"Error processing stored procedure {stored_procedure_name} after retry: {retry_e}"
                            )

        conn.close()
        logging.info(f"Closed connection to SQL Server")

        output_file = json_file.replace("CodeGen.json", "CodeGen_Metadata.json")
        logging.info(f"Writing updated metadata to {output_file}")
        with open(output_file, "w", encoding="utf-8") as file:
            json.dump(data, file, indent=4)
        logging.info(f"Updated {output_file} with SQL Server metadata")

    except pyodbc.Error as e:
        logging.error(f"Error connecting to SQL Server: {e}")
        raise


def get_latest_git_folder(base_path):
    # Get all folders in the base_path
    folders = [f for f in os.listdir(base_path) if os.path.isdir(os.path.join(base_path, f)) and f.startswith("git")]

    # Sort folders by creation time
    latest_folder = max(folders, key=lambda f: os.path.getctime(os.path.join(base_path, f)))
    return os.path.join(base_path, latest_folder)

def main():
    config = load_config("config.json")
    base_path = config["base_path"]
    directory = get_latest_git_folder(base_path)
    sql_config = config["sql_server"]
    connection_string = f"DRIVER={{ODBC Driver 17 for SQL Server}};SERVER={sql_config['server']};DATABASE={sql_config['database']};UID={sql_config['username']};PWD={sql_config['password']}"
    json_file = os.path.join(directory, config["output_file"])
    update_json_with_metadata(json_file, connection_string)
    logging.info(f"Metadata retrieval process completed successfully")


if __name__ == "__main__":
    main()
