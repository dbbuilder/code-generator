import os
import re
import json
import logging

# Configure logging to write to a log file
logging.basicConfig(
    filename="extract_stored_procedures.log",
    level=logging.INFO,
    format="%(asctime)s - %(levelname)s - %(message)s",
)


def load_config(config_file):
    """Load configuration from a JSON file"""
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


def extract_stored_procedures_from_vb(file_content):
    """Extract stored procedure calls from a VB file content"""
    # Pattern to match CommandText = "..."
    command_text_pattern = re.compile(r'CommandText\s*=\s*"([^"]+)"')
    # Pattern to match StorageItems.Add(New DataStorageItem(StorageType.Sql, "...")
    storage_item_pattern = re.compile(
        r'StorageItems\.Add\(New DataStorageItem\(StorageType\.Sql,\s*"([^"]+)"\)\)'
    )

    command_text_matches = command_text_pattern.findall(file_content)
    storage_item_matches = storage_item_pattern.findall(file_content)

    return command_text_matches + storage_item_matches


def extract_class_names(file_content):
    """Extract VB class names"""
    pattern = re.compile(r"Public\s+Class\s+(\w+)")
    matches = pattern.findall(file_content)
    return matches


def process_vb_file(file_path):
    """Process a single VB file to extract stored procedures and class names"""
    try:
        with open(file_path, "r", encoding="utf-8", errors="ignore") as file:
            file_content = file.read()
            stored_procedures = extract_stored_procedures_from_vb(file_content)
            class_names = extract_class_names(file_content)
            return class_names, stored_procedures
    except Exception as e:
        logging.error(f"Error processing file {file_path}: {e}")
        return [], []


def process_directory(directory):
    """Recursively process all .vb files in a directory"""
    all_vb_files_data = {}
    class_sources = {}

    for project_folder in os.listdir(directory):
        project_path = os.path.join(directory, project_folder)
        if os.path.isdir(project_path):
            vb_files_data = {}
            for root, _, files in os.walk(project_path):
                for file in files:
                    if file.endswith(".vb"):
                        file_path = os.path.join(root, file)
                        class_names, stored_procedures = process_vb_file(file_path)
                        for class_name, stored_procedure in zip(
                            class_names, stored_procedures
                        ):
                            if class_name in vb_files_data:
                                logging.warning(
                                    f"Duplicate class name {class_name} found in file {file_path}. Original source: {class_sources[class_name]}"
                                )
                            vb_files_data[class_name] = stored_procedure
                            class_sources[class_name] = file_path
            all_vb_files_data[project_folder] = vb_files_data
    return all_vb_files_data


def generate_json_data(all_vb_files_data):
    """Generate JSON data from extracted VB files data"""
    json_data = {"Namespaces": []}

    for project_name, vb_files_data in all_vb_files_data.items():
        project_data = {"Namespace": project_name, "Objects": []}
        objects = {}
        for class_name, stored_procedure in vb_files_data.items():
            obj_name = project_name
            if obj_name not in objects:
                objects[obj_name] = {"Name": obj_name, "StoredProcedures": []}
            objects[obj_name]["StoredProcedures"].append(
                {
                    "StoredProcedureName": stored_procedure,
                    "FunctionName": class_name,
                    "Parameters": [],  # Parameters extraction can be added if needed
                    "ReturnType": "void",  # ReturnType extraction can be added if needed
                }
            )

        project_data["Objects"] = list(objects.values())
        json_data["Namespaces"].append(project_data)

    # Sort the JSON data by Namespace, FunctionName, and StoredProcedureName
    json_data["Namespaces"].sort(key=lambda x: x["Namespace"])
    for namespace in json_data["Namespaces"]:
        namespace["Objects"].sort(key=lambda x: x["Name"])
        for obj in namespace["Objects"]:
            obj["StoredProcedures"].sort(
                key=lambda x: (x["FunctionName"], x["StoredProcedureName"])
            )

    return json_data


def save_json_data(json_data, output_file):
    """Save JSON data to a file"""
    try:
        with open(output_file, "w", encoding="utf-8") as file:
            json.dump(json_data, file, indent=4)
        logging.info(f"JSON data has been saved to {output_file}")
    except Exception as e:
        logging.error(f"Error saving JSON data to {output_file}: {e}")

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
    #directory = config["vb_files_directory"]
    output_file = os.path.join(directory, config["output_file"])

    all_vb_files_data = process_directory(directory)
    json_data = generate_json_data(all_vb_files_data)
    save_json_data(json_data, output_file)


if __name__ == "__main__":
    main()
