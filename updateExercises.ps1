# Define the root folder
$rootFolder = "."

# Get all subfolders of the root folder
$subfolders = Get-ChildItem -Path $rootFolder -Directory | Where-Object { -not $_.Name.StartsWith(".") }

# Iterate through each subfolder
foreach ($subfolder in $subfolders) {
    # Get all subfolders of the current subfolder
    $subSubfolders = Get-ChildItem -Path $subfolder.FullName -Directory | Where-Object { -not $_.Name.StartsWith(".") }

    # Iterate through each sub-subfolder
    foreach ($subSubfolder in $subSubfolders) {
        # Run the command with the appropriate parameters
        $track = $subfolder.Name
        $exercise = $subSubfolder.Name
        $command = "exercism download --track=$track --exercise=$exercise --force"
        Invoke-Expression $command
    }
}
