This project contains some .NET templates to initialize new service solution or add some kind of projects.

## Build, publish and install

- To build and publish the templates locally, use the **publish-pacakge.sh** script:
    ```
    ./publish-package.sh [-h] [--notag] <version> <output-folder>
    ```
- To install the package, see [here](https://docs.microsoft.com/en-us/dotnet/core/install/templates?pivots=os-windows):
    ```
    dotnet new -i <output-folder>\Smusdi.Templates.<version>.nupkg
    ```

## Templates

### Solution Template

Used to initialize the solution for a new service:
```
dotnet new smusdi-service --help

dotnet new smusdi-service --name=<service-name> --output=<output-folder> -oa=<oauth-url> -ap=<appsettings-folder-name> -p:a=<appsettings-folder-path>

    <service-name>: name of the service in PascalCase with no '-'
    <output-folder>: if not set, all the files are created in the current folder
    <oauth-url>: Url of the oauth2/oidc service
    <appsettings-folder-name>: Folder name of the appsettings files
    <appsettings-folder-path>: Relative path of the appsettings files folder
```
