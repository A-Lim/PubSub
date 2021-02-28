$msBuildExe = 'C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe'

&$msbuildExe /target:publish (
    "PubSub.sln", 
    "/p:PublishProtocol=FileSystem", 
    "/p:TargetFramework=netcoreapp3.1", 
    "/p:DeployOnBuild=true", 
    "/p:PublishDir=bin\Release\netcoreapp3.1\publish\",
    "/p:Platform=x86", 
    "/p:PublishReadyToRun=True", 
    "/p:Configuration=Release",
    "/p:PublishSingleFile=False",
    "/p:SelfContained=True",
    "/p:UseAppHost=True",
    "/p:Platform=x86",
    "/p:RuntimeIdentifier=win-x86",
    "/p:PublishReadyToRun=True",
    "/p:PublishTrimmed=True"
)

#Start-Process cmd "/c `".\PubSub\obj\Release\netcoreapp3.1\win-x86\IBS.exe `""
& ".\PubSub\bin\Release\netcoreapp3.1\publish\IBS.exe"

#Read-Host -Prompt "Press Enter to exit"