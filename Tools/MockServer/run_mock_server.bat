@echo off
setlocal
cd /d "%~dp0\..\.."
python Tools\MockServer\mock_login_server.py %*
if errorlevel 1 (
  echo.
  echo Mock server exited with an error.
  pause
)
endlocal
