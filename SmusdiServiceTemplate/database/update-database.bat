@echo off 

SET BASEDIR=%~dp0
CALL %BASEDIR%/init-env.bat
dotnet dotnet-ef database update %1 -s %BASEDIR%\\PostgreSqlMigration\\PostgreSqlMigration.csproj
