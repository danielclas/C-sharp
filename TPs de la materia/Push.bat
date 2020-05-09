echo off
cls
set /p commmit= "Commit message:  "
git config user.name "danielclas"
git config user.email "danielclas@outlook.es"
git add .
git commit -m " %commmit% "
git push
pause
