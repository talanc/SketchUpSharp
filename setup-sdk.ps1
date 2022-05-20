$rootDir = Split-Path $PSCommandPath

$sdkZip = Join-Path (Join-Path $rootDir "downloads") "SDK_WIN_x64_2021-0-339.zip"
$sdkDir = Join-Path $rootDir "sdk"

if (Test-Path -Path $sdkDir) {
    Write-Output "Deleting existing sdk directory: $sdkDir"
    Remove-Item $sdkDir -Recurse -Force
}

Expand-Archive $sdkZip $sdkDir
