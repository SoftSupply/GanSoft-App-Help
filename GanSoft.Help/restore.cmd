@echo off
echo Install bower
npm install -g bower
pause
echo Restore packages
mkdir components
bower install jquery
bower install bootstrap
bower install font-awesome
bower install jasny-bootstrap
pause