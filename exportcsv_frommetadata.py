import json
import csv
import os

def extract_functions(metadata, output_file):
    """Extract functions with both scalar and result set returns to a single CSV."""
    with open(output_file, mode='w', newline='', encoding='utf-8') as file:
        writer = csv.writer(file)
        # Write the header
        writer.writerow(["Namespace", "Object_Name", "FunctionName", "StoredProcedureName", "ReturnType", 
                         "ReturnItem1_Name&Type", "ReturnItem2_Name&Type", "ReturnItem3_Name&Type", 
                         "ReturnItem4_Name&Type", "ReturnItem5_Name&Type"])  # Add more if needed

        for ns in metadata["Namespaces"]:
            namespace = ns["Namespace"]
            for obj in ns["Objects"]:
                object_name = obj["Name"]
                for sp in obj["StoredProcedures"]:
                    function_name = sp["FunctionName"]
                    sp_name = sp["StoredProcedureName"]
                    return_type = sp.get("ReturnType", {})
                    
                    scalar_return_type = return_type.get("ScalarReturnType")
                    result_set = return_type.get("ResultSet")
                    
                    if scalar_return_type and not result_set:
                        # Scalar return type only
                        writer.writerow([namespace, object_name, function_name, sp_name, "Scalar", scalar_return_type])
                    elif result_set:
                        # Result set return type
                        row = [namespace, object_name, function_name, sp_name, "ResultSet"]
                        for item in result_set:
                            row.append(f"{item['Name']} ({item['CSharpType']})")
                        writer.writerow(row)
                    else:
                        # Case where there is no return type
                        writer.writerow([namespace, object_name, function_name, sp_name, "None"])

def main():
    # Load the configuration
    with open("config.json", "r", encoding='utf-8') as config_file:
        config = json.load(config_file)

    # Determine the paths and output filenames
    directory = config["vb_files_directory"]
    json_filename = config["output_file"]
    json_file = os.path.join(directory, json_filename)
    
    # Load the metadata from the JSON file
    with open(json_file, "r", encoding='utf-8') as file:
        metadata = json.load(file)

    # Extract and write to CSV file
    output_csv = os.path.join(directory, "ExtractedFunctions.csv")
    extract_functions(metadata, output_csv)

if __name__ == "__main__":
    main()
