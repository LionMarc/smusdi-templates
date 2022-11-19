@echo off 

SET BASEDIR=%~dp0
CALL %BASEDIR%/init-env.bat
dotnet dotnet-ef migrations remove -s %BASEDIR%\\PostgreSqlMigration\\PostgreSqlMigration.csproj --context MigrationDbContext
