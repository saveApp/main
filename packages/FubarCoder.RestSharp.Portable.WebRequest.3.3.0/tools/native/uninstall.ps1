param($installPath, $toolsPath, $package, $project)

$obj = $project.Object
$getRefsMethod = [Microsoft.VisualStudio.Project.VisualC.VCProjectEngine.VCProjectShim].GetMethod("get_References")
$refs = $getRefsMethod.Invoke($obj, $null)
$assemblyRef = $refs.Find("RestSharp.Portable.WebRequest")
if ($assemblyRef -ne $NULL) {
	$assemblyRef.Remove();
}
