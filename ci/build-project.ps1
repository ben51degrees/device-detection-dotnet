param(
    [Parameter(Mandatory=$true)]
    [string]$RepoName = "device-detection-dotnet",
    [string]$ProjectDir = ".",
    [string]$Name = "Release_x64",
    [string]$Configuration = "Release",
    [string]$Arch = "x64",
    [string]$BuildMethod = "msbuild"
)

if ($BuildMethod -eq "dotnet"){

    if ($IsWindows) {
        ./dotnet/build-project-core.ps1 -RepoName $RepoName -ProjectDir $ProjectDir -Name $Name -Configuration $Configuration -Arch $Arch
    }
    else {
        # On non-Windows, use the solution filter to remove the Framework projects.
        ./dotnet/build-project-core.ps1 -RepoName $RepoName -ProjectDir "./FiftyOne.DeviceDetection.Core.slnf" -Name $Name -Configuration $Configuration -Arch $Arch
    }

}
else{
    ./dotnet/build-project-framework.ps1 -RepoName $RepoName -ProjectDir $ProjectDir -Name $Name -Configuration $Configuration -Arch $Arch
}

exit $LASTEXITCODE