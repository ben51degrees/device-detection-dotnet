param(
    [string]$ProjectDir = "FiftyOne.DeviceDetection.Hash.Engine.OnPremise",
    [string]$Name = "Release_x64",
    [Parameter(Mandatory=$true)]
    [string]$RepoName,
    [string]$Arch
)

if($IsLinux){
    # Because .NET does not officially support the x86 architecture on Linux distributions, we are using the x64 job to build x86 binaries.
    $Archs = @("x86", "x64")
    foreach($a in $Archs){
        ./dotnet/build-package-requirement.ps1 -RepoName $RepoName -ProjectDir $ProjectDir -Name $Name -Configuration "Release" -Arch $a
        
        # CMake generates build files specific to the architecture. We are deleting the build folder to ensure clean build enviroment. 
        Remove-Item -LiteralPath "$RepoPath/$ProjectDir/build" -Force -Recurse -ErrorAction SilentlyContinue
    }
}
elseif ($IsMacOS -and $Arch -eq "ARM64") {
     
    ./cxx/build-project.ps1 -RepoName $RepoName -ProjectDir $ProjectDir -Configuration $Configuration -ExtraArgs "-DCMAKE_OSX_ARCHITECTURES=arm64" -Arch $Arch

}
else{
    ./dotnet/build-package-requirement.ps1 -RepoName $RepoName -ProjectDir $ProjectDir -Name $Name -Configuration "Release" -Arch $Arch
}

$RepoPath = [IO.Path]::Combine($pwd, $RepoName)

# Verify that the path to binaries exists and copy it to package-files folder  
if ($IsWindows) {
    $Subfolder = "windows"
}
elseif ($IsLinux) {
    $Subfolder = "linux"
}
elseif ($IsMacOS) {
    $Subfolder = "macos"
}
else {
    Write-Host "No appropriate subfolder found."
    exit
}

$NativeFilesFolder = [IO.Path]::Combine($RepoPath, $ProjectDir, "build", $Subfolder, $Arch, "Release") 

$PackageFolder = "package-files"
New-Item -Path $PackageFolder -ItemType Directory -Force


Copy-Item -Path "$NativeFilesFolder" -Destination "$PackageFolder" -Recurse -Force


exit $LASTEXITCODE
