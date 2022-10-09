@echo off 

SET BASEDIR=%~dp0
CALL %BASEDIR%/init-env.bat
dotnet dotnet-ef migrations add %1 -s %BASEDIR%\\PostgreSqlMigration\\PostgreSqlMigration.csproj
