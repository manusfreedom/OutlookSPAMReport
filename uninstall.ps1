$envCommonProgramFiles = [System.Environment]::GetEnvironmentVariable('CommonProgramFiles');
$envProgramFiles = [System.Environment]::GetEnvironmentVariable('ProgramFiles');
$scriptDir = Split-Path -Parent -Path $MyInvocation.MyCommand.Path;
. "$envCommonProgramFiles\microsoft shared\VSTO\10.0\VSTOInstaller.exe" /uninstall "$scriptDir\OutlookSPAMReport.vsto" | Out-Null;