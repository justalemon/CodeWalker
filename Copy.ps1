param(
    [Parameter(Mandatory=$true)]
    [string]$To
)

$To = [IO.Path]::GetFullPath($To.Trim('"'))  # VS Bug... since 2008 (if not before lol)
$Icons = [IO.Path]::GetFullPath("..\Icons")
$Shaders = [IO.Path]::GetFullPath("..\Shaders")

Write-Output "Output Directory is $($To)"
Write-Output "Icons are located in $($Icons)"
Write-Output "Shaders are located in $($Shaders)"

$NewIcons = [IO.Path]::Combine($To, "Icons")
$NewShaders = [IO.Path]::Combine($To, "Shaders")

Write-Output "Deleting Existing Icons directory"
if (Test-Path $NewIcons) { Remove-Item $NewIcons -Recurse; }
Write-Output "Deleting Existing Shaders directory"
if (Test-Path $NewShaders) { Remove-Item $NewShaders -Recurse; }

Write-Output "Copying Icons to $($NewIcons)"
Copy-Item -Path $Icons -Destination $NewIcons -Recurse
Write-Output "Copying Shaders to $($NewShaders)"
Copy-Item -Path $Shaders -Destination $NewShaders -Recurse
