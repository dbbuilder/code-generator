import json
import csv
import os
import logging

# Configure logging
logging.basicConfig(level=logging.DEBUG, format="%(asctime)s - %(levelname)s - %(message)s")

def extract_functions(metadata, output_file):
    """Extract functions with both scalar and result set returns to a single CSV."""
    with open(output_file, mode='w', newline='', encoding='utf-8') as file:
        writer = csv.writer(file)
        
        # Write the header
        writer.writerow([
            "Namespace", "Object_Name", "FunctionName", "StoredProcedureName", 
            "ReturnType", "ScalarReturnType", "ResultSetItem1_Name&Type", 
            "ResultSetItem2_Name&Type", "ResultSetItem3_Name&Type", 
            "ResultSetItem4_Name&Type", "ResultSetItem5_Name&Type"
        ])

        for ns in metadata.get("Namespaces", []):
            namespace = ns.get("Namespace", "")
            logging.debug(f"Processing namespace: {namespace}")
            
            for obj in ns.get("Objects", []):
                object_name = obj.get("Name", "")
                logging.debug(f"Processing object: {object_name} in namespace: {namespace}")
                
                for sp in obj.get("StoredProcedures", []):
                    function_name = sp.get("FunctionName", "")
                    sp_name = sp.get("StoredProcedureName", "")
                    return_type = sp.get("ReturnType", None)

                    logging.debug(f"Processing stored procedure: {sp_name} with function name: {function_name}")
                    logging.debug(f"ReturnType structure: {return_type}")

                    # Initialize row data
                    row = [namespace, object_name, function_name, sp_name]

                    # Check if ReturnType is a dictionary or a string
                    if isinstance(return_type, dict):
                        # Handle ResultSet
                        result_set = return_type.get("ResultSet", [])
                        if result_set:
                            row.append("ResultSet")
                            for item in result_set:
                                row.append(f"{item.get('Name', '')} ({item.get('CSharpType', '')})")
                        else:
                            row.append("None")

                        # Handle ScalarReturnType
                        scalar_return_type = return_type.get("Scalar", None)
                        if scalar_return_type:
                            row.append(scalar_return_type)
                        else:
                            row.append("None")
                    elif isinstance(return_type, str):
                        # Handle the case where ReturnType is a simple string (e.g., "int")
                        row.append("Scalar")
                        row.append(return_type)
                    else:
                        logging.debug(f"No specific return type found for stored procedure: {sp_name}")
                        row.append("None")
                        row.append("None")

                    # Write the row to the CSV, ensuring only the first 5 result set items are included
                    writer.writerow(row[:11])

def main():
    # Load the configuration
    config_file = "config.json"
    with open(config_file, "r", encoding='utf-8') as config_file:
        config = json.load(config_file)
        logging.debug(f"Loaded configuration: {config}")

    # Determine the paths and output filenames
    directory = config["vb_files_directory"]
    json_filename = config["output_file"]
    json_file = os.path.join(directory, json_filename)

    # Load the metadata from the JSON file
    logging.debug(f"Loading metadata from: {json_file}")
    with open(json_file, "r", encoding='utf-8') as file:
        metadata = json.load(file)
        logging.debug(f"Loaded metadata: {metadata}")

    # Extract and write to CSV file
    output_csv = os.path.join(directory, "ExtractedFunctions.csv")
    logging.debug(f"Writing extracted data to: {output_csv}")
    extract_functions(metadata, output_csv)
    logging.info(f"Extraction completed successfully and written to {output_csv}")

if __name__ == "__main__":
    main()
