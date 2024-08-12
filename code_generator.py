import json
import os
import logging

# Configure logging
current_dir = os.path.dirname(os.path.abspath(__file__))
log_file = os.path.join(current_dir, "code_generator.log")
logging.basicConfig(
    level=logging.DEBUG,
    format="%(asctime)s %(levelname)s %(message)s",
    handlers=[logging.FileHandler(log_file), logging.StreamHandler()],
)


def get_csharp_type(sql_type):
    """Map SQL data types to C# data types"""
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
    }
    return type_mapping.get(str(sql_type).lower(), "object")


def generate_fields(fields):
    """Generate fields for model classes based on parameters"""
    field_definitions = ""
    for field in fields:
        field_type = get_csharp_type(field["Type"])
        field_definitions += (
            f"public {field_type} {field['Name'][1:]}" + " { get; set; }\n"
        )
    return field_definitions


def generate_methods(stored_procedures):
    """Generate methods for service and repository interfaces and classes"""
    methods = ""
    for sp in stored_procedures:
        return_type = get_csharp_type(sp["ReturnType"])
        if return_type == "object":
            return_type = "Task"
        else:
            return_type = f"Task<{return_type}>"
        method_name = sp["FunctionName"]
        params = ", ".join(
            [
                f"{get_csharp_type(param['Type'])} {param['Name'][1:]}"
                for param in sp["Parameters"]
            ]
        )
        methods += f"{return_type} {method_name}({params});\n"
    return methods


def generate_function_methods(stored_procedures, namespace_name):
    """Generate function methods for the function class based on stored procedures"""
    function_methods = ""
    for sp in stored_procedures:
        return_type = get_csharp_type(sp["ReturnType"])
        method_name = sp["FunctionName"]
        params = ", ".join(
            [
                f"{get_csharp_type(param['Type'])} {param['Name'][1:]}"
                for param in sp["Parameters"]
            ]
        )
        method_body = f"""public async {return_type} {method_name}({params})
{{
    try
    {{
        // Assuming the service method has the same name
        return await _{namespace_name}Service.{method_name}({', '.join([param['Name'][1:] for param in sp['Parameters']])});
    }}
    catch (Exception ex)
    {{
        _logger.LogError(ex, "Error in {method_name}");
        throw;
    }}
}}\n"""
        function_methods += method_body
    return function_methods


def generate_repository_methods(stored_procedures, namespace_name):
    """Generate repository methods for calling stored procedures and reading data into objects"""
    repository_methods = ""
    for sp in stored_procedures:
        if "StoredProcedureName" not in sp:
            logging.warning(
                f"Stored procedure {sp['FunctionName']} in namespace {namespace_name} does not contain 'StoredProcedureName' key."
            )
            continue
        return_type = get_csharp_type(sp["ReturnType"])
        method_name = sp["FunctionName"]
        params = ", ".join(
            [
                f"{get_csharp_type(param['Type'])} {param['Name'][1:]}"
                for param in sp["Parameters"]
            ]
        )
        sql_params = ", ".join(
            [
                f"new SqlParameter(\"@{param['Name'][1:]}\", {param['Name'][1:]})"
                for param in sp["Parameters"]
            ]
        )
        read_data = ""
        if return_type == "object":
            read_data = f"""var result = new List<{method_name}Model>();
                    while (reader.Read())
                    {{
                        var obj = new {method_name}Model();
                        foreach (var prop in typeof({method_name}Model).GetProperties())
                        {{
                            if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
                            {{
                                prop.SetValue(obj, reader[prop.Name]);
                            }}
                        }}
                        result.Add(obj);
                    }}
                    return result;"""
        else:
            read_data = "return (T)reader[0];"

        method_body = f"""public async Task<{return_type}> {method_name}({params})
{{
    using (var connection = new SqlConnection(_connectionString))
    {{
        using (var command = new SqlCommand("{sp['StoredProcedureName']}", connection))
        {{
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(new []{{{sql_params}}});
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {{
                {read_data}
            }}
        }}
    }}
}}\n"""
        repository_methods += method_body
    return repository_methods


def generate_model_classes(objects, namespace_name, namespace_dir, model_template):
    """Generate model classes based on the objects in the metadata"""
    logging.debug(f"Model template content: {model_template}")
    for obj in objects:
        class_name = obj["Name"]
        logging.debug(
            f"Generating model class for {class_name} in namespace {namespace_name}."
        )
        if "Fields" not in obj:
            logging.warning(
                f"Object {class_name} in namespace {namespace_name} does not contain 'Fields' key."
            )
            continue
        fields = generate_fields(obj["Fields"])
        logging.debug(f"Generated fields for {class_name}: {fields}")
        model_class_content = model_template.format(
            namespace=namespace_name, class_name=class_name, fields=fields
        )
        model_class_path = os.path.join(namespace_dir, f"{class_name}_Models.cs")
        logging.debug(f"Writing model class {class_name} to {model_class_path}.")
        with open(model_class_path, "w") as file:
            file.write(model_class_content)
        logging.info(
            f"Model class {class_name} for namespace {namespace_name} generated and written to {model_class_path}."
        )


def generate_code():
    try:
        # Resolve the template directory and the output directory from the current directory
        template_dir = os.path.join(current_dir, "templates")
        output_dir = os.path.join(current_dir, "GeneratedCode")

        # Ensure the output directory exists
        os.makedirs(output_dir, exist_ok=True)
        logging.info(f"Output directory {output_dir} created or already exists.")

        # Load the configuration to get the output file path
        config_path = os.path.join(current_dir, "config.json")
        with open(config_path, "r") as config_file:
            config = json.load(config_file)
            output_file = config["output_file"]
            logging.info(f"Configuration loaded. Output file: {output_file}")

        # Replace _metadata with the appropriate name and construct the path to codegen_metadata.json
        metadata_file = output_file.replace("_metadata", "")
        metadata_path = os.path.join(current_dir, metadata_file)
        logging.info(f"Metadata file path resolved: {metadata_path}")

        # Load the metadata
        with open(metadata_path, "r") as file:
            metadata = json.load(file)
            logging.info("Metadata loaded successfully.")

        # Load the templates
        with open(os.path.join(template_dir, "function_template.txt"), "r") as file:
            function_template = file.read()

        with open(os.path.join(template_dir, "model_template.txt"), "r") as file:
            model_template = file.read()
            logging.debug(f"Loaded model template: {model_template}")

        with open(
            os.path.join(template_dir, "repository_class_template.txt"), "r"
        ) as file:
            repository_class_template = file.read()

        with open(
            os.path.join(template_dir, "repository_interface_template.txt"), "r"
        ) as file:
            repository_interface_template = file.read()

        with open(
            os.path.join(template_dir, "service_class_template.txt"), "r"
        ) as file:
            service_class_template = file.read()

        with open(
            os.path.join(template_dir, "service_interface_template.txt"), "r"
        ) as file:
            service_interface_template = file.read()

        # Generate code based on metadata
        for namespace in metadata["Namespaces"]:
            namespace_name = namespace["Namespace"]
            objects = namespace.get("Objects", [])
            if not objects:
                logging.info(
                    f"Skipping namespace {namespace_name} as it contains no objects."
                )
                continue

            # Create the namespace directory inside the output directory
            namespace_dir = os.path.join(output_dir, namespace_name)
            os.makedirs(namespace_dir, exist_ok=True)
            logging.info(
                f"Namespace directory {namespace_dir} created or already exists."
            )

            # Generate model classes for the namespace
            generate_model_classes(
                objects, namespace_name, namespace_dir, model_template
            )

            # Collect all methods for repository and service for the namespace
            all_methods = ""
            function_methods = ""
            repository_methods = ""
            for obj in objects:
                stored_procedures = obj.get("StoredProcedures", [])
                all_methods += generate_methods(stored_procedures)
                function_methods += generate_function_methods(
                    stored_procedures, namespace_name
                )
                repository_methods += generate_repository_methods(
                    stored_procedures, namespace_name
                )

            # Generate repository interface for the namespace
            repository_interface = repository_interface_template.format(
                namespace=namespace_name,
                interface_name=f"I{namespace_name}Repository",
                methods=all_methods,
            )
            with open(
                os.path.join(namespace_dir, f"I{namespace_name}Repository.cs"), "w"
            ) as file:
                file.write(repository_interface)
            logging.info(
                f"Repository interface for namespace {namespace_name} generated."
            )

            # Generate repository class for the namespace
            repository_class = repository_class_template.format(
                namespace=namespace_name,
                class_name=f"{namespace_name}Repository",
                interface_name=f"I{namespace_name}Repository",
                methods=repository_methods,
            )
            with open(
                os.path.join(namespace_dir, f"{namespace_name}Repository.cs"), "w"
            ) as file:
                file.write(repository_class)
            logging.info(f"Repository class for namespace {namespace_name} generated.")

            # Generate service interface for the namespace
            service_interface = service_interface_template.format(
                namespace=namespace_name,
                interface_name=f"I{namespace_name}Service",
                methods=all_methods,
            )
            with open(
                os.path.join(namespace_dir, f"I{namespace_name}Service.cs"), "w"
            ) as file:
                file.write(service_interface)
            logging.info(f"Service interface for namespace {namespace_name} generated.")

            # Generate service class for the namespace
            service_class = service_class_template.format(
                namespace=namespace_name,
                class_name=f"{namespace_name}Service",
                interface_name=f"I{namespace_name}Service",
                methods=all_methods,
            )
            with open(
                os.path.join(namespace_dir, f"{namespace_name}Service.cs"), "w"
            ) as file:
                file.write(service_class)
            logging.info(f"Service class for namespace {namespace_name} generated.")

            # Generate function class for the namespace
            constructor_fields = (
                f"private readonly I{namespace_name}Service _{namespace_name}Service;"
            )
            constructor_injections = f"I{namespace_name}Service {namespace_name}Service"
            constructor_assignments = (
                f"_{namespace_name}Service = {namespace_name}Service;"
            )
            function_class = function_template.format(
                namespace=namespace_name,
                class_name=f"{namespace_name}Functions",
                constructor_fields=constructor_fields,
                constructor_injections=constructor_injections,
                constructor_assignments=constructor_assignments,
                function_methods=function_methods,
            )
            with open(
                os.path.join(namespace_dir, f"{namespace_name}Functions.cs"), "w"
            ) as file:
                file.write(function_class)
            logging.info(f"Function class for namespace {namespace_name} generated.")

        logging.info("Code generation complete.")

    except Exception as e:
        logging.error("An error occurred during code generation", exc_info=True)


def main():
    generate_code()


if __name__ == "__main__":
    main()
