$msbuild = "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe"
$options = "/p:DeployOnBuild=true /p:PublishProfile='E:\Sitecore\ucsfPractice\Source\Project.Global\Properties\PublishProfiles\FolderProfile.pubxml' /p:VisualStudioVersion=14.0 /p:AspnetMergePath='C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.2 Tools'"

	



get-childitem "E:\Sitecore\ucsfPractice\Source" -recurse | where {$_.extension -eq ".csproj"} | % {
	 $build = $msbuild + " " +$_.FullName +" " + $options
	Invoke-Expression $build
}


