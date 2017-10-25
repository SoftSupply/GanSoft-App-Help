@echo off
"%programfiles(x86)%\IIS Express\iisexpress.exe"  /config:".vs\config\applicationhost.config" /site:"GanSoft.App.Help" /apppool:"Clr4IntegratedAppPool"