import json
import csv
import os
import logging

# Configure logging
logging.basicConfig(
    level=logging.DEBUG, format="%(asctime)s - %(levelname)s - %(message)s"
)


def extract_functions(metadata, output_file):
    """Extract functions with both scalar and result set returns to a single CSV."""
    if not metadata or not output_file:
        raise ValueError("metadata and output_file must both be provided")

    with open(output_file, mode="w", newline="", encoding="utf-8") as file:
        writer = csv.writer(file)

        # Write the header (allow up to 10 result set items)
        header = [
            "Namespace",
            "Object_Name",
            "FunctionName",
            "StoredProcedureName",
            "ScalarReturnType",
        ] + [f"ResultSetItem{i+1}_Name&Type" for i in range(10)]
        writer.writerow(header)

        for ns in metadata.get("Namespaces", []):
            namespace = ns.get("Namespace", "")
            logging.debug(f"Processing namespace: {namespace}")

            if not namespace:
                logging.warning("Namespace is empty")
                continue

            for obj in ns.get("Objects", []):
                object_name = obj.get("Name", "")
                logging.debug(
                    f"Processing object: {object_name} in namespace: {namespace}"
                )

                if not object_name:
                    logging.warning("Object name is empty")
                    continue

                for sp in obj.get("StoredProcedures", []):
                    function_name = sp.get("FunctionName", "")
                    sp_name = sp.get("StoredProcedureName", "")
                    scalar_return_type = sp.get("Scalar", None)
                    result_set = sp.get("ResultSet", [])

                    logging.debug(
                        f"Processing stored procedure: {sp_name} with function name: {function_name}"
                    )
                    logging.debug(
                        f"ScalarReturnType: {scalar_return_type}, ResultSet: {result_set}"
                    )

                    if not sp_name:
                        logging.warning("Stored procedure name is empty")
                        continue

                    # Initialize row data
                    row = [namespace, object_name, function_name, sp_name]

                    # Append ScalarReturnType
                    row.append(scalar_return_type if scalar_return_type else "None")

                    # Append ResultSet items (up to 10)
                    for item in result_set[:10]:
                        name = item.get("Name", "")
                        csharp_type = item.get("CSharpType", "")
                        row.append(f"{name} ({csharp_type})" if name and csharp_type else "")

                    # Ensure the row has exactly 15 columns (add empty columns if fewer result set items)
                    row += [""] * (15 - len(row))

                    # Write the row to the CSV
                    writer.writerow(row)
def extract_functions(metadata, output_file):
    """Extract functions with both scalar and result set returns to a single CSV."""
    with open(output_file, mode="w", newline="", encoding="utf-8") as file:
        writer = csv.writer(file)

        # Write the header (allow up to 10 result set items)
        header = [
            "Namespace",
            "Object_Name",
            "FunctionName",
            "StoredProcedureName",
            "ScalarReturnType",
        ] + [f"ResultSetItem{i+1}_Name&Type" for i in range(10)]
        writer.writerow(header)

        for ns in metadata.get("Namespaces", []):
            namespace = ns.get("Namespace", "")
            logging.debug(f"Processing namespace: {namespace}")

            for obj in ns.get("Objects", []):
                object_name = obj.get("Name", "")
                logging.debug(
                    f"Processing object: {object_name} in namespace: {namespace}"
                )

                for sp in obj.get("StoredProcedures", []):
                    function_name = sp.get("FunctionName", "")
                    sp_name = sp.get("StoredProcedureName", "")
                    scalar_return_type = sp.get("Scalar", None)
                    result_set = sp.get("ResultSet", [])

                    logging.debug(
                        f"Processing stored procedure: {sp_name} with function name: {function_name}"
                    )
                    logging.debug(
                        f"ScalarReturnType: {scalar_return_type}, ResultSet: {result_set}"
                    )

                    # Initialize row data
                    row = [namespace, object_name, function_name, sp_name]

                    # Append ScalarReturnType
                    row.append(scalar_return_type if scalar_return_type else "None")

                    # Append ResultSet items (up to 10)
                    for item in result_set[:10]:
                        row.append(
                            f"{item.get('Name', '')} ({item.get('CSharpType', '')})"
                        )

                    # Ensure the row has exactly 15 columns (add empty columns if fewer result set items)
                    while len(row) < 15:
                        row.append("")

                    # Write the row to the CSV
                    writer.writerow(row)

def get_latest_git_folder(base_path):
    # Get all folders in the base_path
    folders = [f for f in os.listdir(base_path) if os.path.isdir(os.path.join(base_path, f)) and f.startswith("git")]

    # Sort folders by creation time
    latest_folder = max(folders, key=lambda f: os.path.getctime(os.path.join(base_path, f)))
    return os.path.join(base_path, latest_folder)


def main():
    # Load the configuration
    config_file = "config.json"
    with open(config_file, "r", encoding="utf-8") as config_file:
        config = json.load(config_file)
        logging.debug(f"Loaded configuration: {config}")

    base_path = config["base_path"]
    directory = get_latest_git_folder(base_path)

 
    json_filename = config["output_file"]
    json_file = os.path.join(directory, json_filename)

    # Load the metadata from the JSON file
    logging.debug(f"Loading metadata from: {json_file}")
    with open(json_file, "r", encoding="utf-8") as file:
        metadata = json.load(file)
        logging.debug(f"Loaded metadata: {metadata}")

    # Extract and write to CSV file
    output_csv = os.path.join(directory, "ExtractedFunctions.csv")
    logging.debug(f"Writing extracted data to: {output_csv}")
    extract_functions(metadata, output_csv)
    logging.info(f"Extraction completed successfully and written to {output_csv}")


if __name__ == "__main__":
    main()
