@echo OFF
cd %~dp0

set path=%~dp0

start /wait  printbarcode.exe  %path%TypeCode.txt TypeCode.txt

ECHO finished.
pause