@echo off & setLocal EnableDelayedExpansion

cd C:\Decryptor
for /F "delims=" %%a in (C:\temp\recordings.txt) do (
  set name=%%a
  call :NAME !name!
  set name=!name:~0,-4!
  encryptwave-w32r-1-1.exe -d "%%a" -o "C:\recordings\!name!.wav"
)
goto :EOF

:NAME
  for /F "tokens=1* delims=\" %%i in ("!name!") do (
    if "%%j"=="" (goto :EOF) else (set name=%%j)
)
goto :NAME
