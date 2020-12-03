# OutlookSPAMReport

Outlook VSTO Add-ins to report spam and ham.

## Getting Started

### Prerequisites to build

What things you need to install the software and how to install them

```
Visual Studio 201x
Outlook 201x
WinRAR (to build SFX)
```

### Prerequisites to use

```
Outlook 201x
```

### Install

Symply run the WinRAR SFX.

### Uninstall

Execute `uninstall.ps1`.

## Deployment

To do

## Built With

* [Visual Studio 2019](https://visualstudio.microsoft.com/vs/)

### WinRAR SFX info

```text
;The comment below contains SFX script commands

Path=Octopoos\OutlookSPAMReport
SavePath
Setup=%windir%\System32\WindowsPowerShell\v1.0\powershell.exe -Command "& { $VSTOInstaller = Get-ChildItem -Path 'HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall', H'KLM:\SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall' | Get-ItemProperty | Where-Object { $_.DisplayName -eq 'Microsoft Visual Studio 2010 Tools for Office Runtime (x64)' } | Select-Object -First 1 | Select-Object -ExpandProperty 'InstallLocation'; Invoke-Expression (\". '\" + $VSTOInstaller + \"VSTOInstaller.exe' /install '\" + (Get-Item .).FullName + \"\OutlookSPAMReport.vsto'\") | Out-Null; }"
Title=Outlook SPAM Report
```

## Authors

* **Romain Lapoux** - *Initial work* - [ManusFreedom](https://github.com/manusfreedom)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
To do

## Acknowledgments

* Internet ;)