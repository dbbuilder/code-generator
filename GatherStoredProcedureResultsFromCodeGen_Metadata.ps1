# Define the path to the JSON file
$jsonFilePath = "C:\dev\codegenerator\codegen_metadata.json"    

# Read the JSON file content
$jsonContent = Get-Content -Path $jsonFilePath -Raw | ConvertFrom-Json

# Function to recursively find all 'StoredProcedureName' properties along with their Namespace and FunctionName
function Find-StoredProcedureDetails {
    param (
        [Parameter(Mandatory = $true)]
        [psobject]$JsonObject,
        [string]$Namespace = ""
    )
    $results = @()
    foreach ($property in $JsonObject.PSObject.Properties) {
        if ($property.Name -eq "StoredProcedureName") {
            $storedProcedureName = $property.Value
            $functionName = $JsonObject.FunctionName
            $results += [pscustomobject]@{
                Name = $storedProcedureName
                NamespaceFunction = "$Namespace--$functionName"
            }
        }
        elseif ($property.Name -eq "Namespace") {
            $Namespace = $property.Value
        }
        elseif ($property.Value -is [System.Collections.IEnumerable]) {
            foreach ($item in $property.Value) {
                if ($item -is [psobject]) {
                    $results += Find-StoredProcedureDetails -JsonObject $item -Namespace $Namespace
                }
            }
        }
        elseif ($property.Value -is [psobject]) {
            $results += Find-StoredProcedureDetails -JsonObject $property.Value -Namespace $Namespace
        }
    }
    return $results
}

# Call the function and get all 'StoredProcedureName' details
$storedProcedureDetails = Find-StoredProcedureDetails -JsonObject $jsonContent

# Group by StoredProcedureName and concatenate Namespace--FunctionName
$groupedResults = $storedProcedureDetails | Group-Object -Property Name | ForEach-Object {
    $name = $_.Name
    $namespacesAndFunctions = $_.Group | ForEach-Object { $_.NamespaceFunction }
    "$name : $($namespacesAndFunctions -join ", ")"
}

# Sort the results by StoredProcedureName
$sortedResults = $groupedResults | Sort-Object

# Define the output file paths
$outputFilePath = Join-Path -Path (Get-Item $jsonFilePath).DirectoryName -ChildPath "StoredProceduresUsed.txt"
$sqlFilePath = Join-Path -Path (Get-Item $jsonFilePath).DirectoryName -ChildPath "Dependencies.sql"

# Write the results to the output file
$sortedResults | Out-File -FilePath $outputFilePath -Encoding UTF8

# Generate the T-SQL script
$sqlScript = @"
SET NOCOUNT ON
DECLARE @StoredProcedureName NVARCHAR(128);

CREATE TABLE #Dependencies (
    ObjectName NVARCHAR(128),
    ObjectType NVARCHAR(128)
);

"@

foreach ($spDetail in $storedProcedureDetails | Select-Object -Unique Name) {
    $storedProcedureName = $spDetail.Name
    $sqlScript += @"
INSERT INTO #Dependencies (ObjectName, ObjectType)
SELECT 
    OBJECT_NAME(referenced_id) AS ObjectName,
    referenced_class_desc AS ObjectType
FROM 
    sys.sql_expression_dependencies 
WHERE 
    OBJECT_NAME(referencing_id) = '$storedProcedureName'
;
"@
}

$sqlScript += @"
DECLARE @i INT
SET @i = 1

WHILE @i < 20
BEGIN
    INSERT INTO #Dependencies (ObjectName, ObjectType)
    SELECT 
        OBJECT_NAME(referenced_id) AS ObjectName,
        referenced_class_desc AS ObjectType
    FROM 
        sys.sql_expression_dependencies 
    WHERE 
        referencing_id IN (SELECT object_id(ObjectName) FROM #Dependencies)
        AND referenced_entity_name NOT IN (SELECT ObjectName FROM #Dependencies)

    SET @i = @i + 1
END

SELECT DISTINCT left(so.name, 50), so.xtype 
FROM #Dependencies AS d
INNER JOIN sysobjects AS so ON so.name = d.ObjectName
WHERE d.ObjectName IS NOT NULL
ORDER BY so.xtype, so.name

DROP TABLE #Dependencies
"@

# Write the T-SQL script to the output file
$sqlScript | Out-File -FilePath $sqlFilePath -Encoding UTF8

# Print a confirmation message
Write-Host "StoredProcedureName values have been written to $outputFilePath"
Write-Host "T-SQL script has been written to $sqlFilePath"
