@echo off
echo Install bower
npm install -g bower
pause
echo Restore packages
mkdir components
bower update
pause