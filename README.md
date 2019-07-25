### Getting Started
Two projects exist within the root of this repository.

* The App - Amorous.App
* The web Client - Amorous.Angular.csproj

### Required Cli-Tools
___
- .Net Core
- Docker
- Angular Cli
- SwaggerCodegen
- docfx
- git
- Git-Credential-Manager


Restore package dependencies
```
cd Amorous
dotnet restore
```
```
cd Amorous.Angular
npm install
```

### Development Driven by Application Scaling

### Commit Type

Must be one of the following:

* **build**: Changes that affect the build system or external dependencies (example scopes: npm)
* **ci**: Changes to our CI configuration files and scripts
* **docs**: Documentation only changes
* **feature**: A new feature
* **bugfix**: A bug fix
* **perf**: A code change that improves performance
* **refactor**: A code change that neither fixes a bug nor adds a feature
* **style**: Changes that do not affect the meaning of the code (white-space, formatting, missing semi-colons, etc)
* **test**: Adding missing tests or correcting existing tests



### Swagger
Use swagger image downloaded from docker to generate api stubs for client application

**Docker**
----------
Docker providing interfaces for both developers and project managers can interface with docker.

Access docker hub directly by visiting the toolbar.

Go to `More of Docker > Docker Hub` to open the docker hub page.

Download your system's docker installation from the [system installations](https://docs.docker.com/v17.12/install/#supported-platforms) page for docker system installations.

**Images**

- Api 
    - Build  - ``docker build . -t fragment-generic/amorous -f ./Amorous.App/Dockerfile``
    - Container - ``docker create -p 5001:5001 --name amorous  fragmen-generic/amorous``


**Downloading documentation to the environment**
----

At the bottom the `.gitignore` file is a listing of necessary external documentation located in the `External.Docs` directory. It is recommended that from the project root you `cd ./External.Docs` directory before cloning external repositories (not modules) into this directory.

**First time doing so** - Create the directory External.Docs  

`mkdir External.Docs`  

**Change to that directory**

`cd ./External.Docs`

Then clone needed documentation

```
mkdir External.Docs
cd ./External.Docs
git clone https://github.com/aspnet/AspNetCore.Docs.git AspNetCore.Docs
git clone https://github.com/aspnet/EntityFrameworkCore.git EntityFrameworkCore
git clone https://github.com/ngrx/platform.git ngrx
git clone https://github.com/domaindrivendev/Swashbuckle.AspNetCore.git Swashbuckle.AspNetCore
cd ..
```


And update or redo as needed. May take a while to download.

Keep in mind that the `External.Docs` directory can be removed from the text editor/IDE's index so as to not bother the developer.
 
**Recommended Tools**
___
- Jetbrains Rider
