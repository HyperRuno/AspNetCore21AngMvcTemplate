# Asp Net Core 2.1 Angular 6 Template
This project solves the lack of an Angular 6 based ASP NET Core project template in Visual Studio. 

This template includes:

1. Net Core API 2.1 (basic MVC, with ValuesController as usual)
2. Swagger (just navigate to your '/swagger')
3. Angular 6 project with Angular CLI (6.0.7) including
	1. MDBootstrap (https://mdbootstrap.com/)
	2. ngx-mapbox-gl (https://github.com/Wykks/ngx-mapbox-gl)
	3. rxjs & rxjs-compat 
4. Docker support (just select docker-compose as startup project and run it)

### Prerequisites
1. Microsoft .NET Core SDK 2.1 (https://www.microsoft.com/net/download/windows)
1. Docker (only if you want to use it with Docker, https://www.docker.com/community-edition)
1. Visual Studio (Code || Professional || Enterprise)
1. Node (8.x) and npm

### Install from the git repo

1. Git clone this repo
1. Install the template `dotnet new --install .\content`
1. Create a directory where you would like to store the project
1. Type `dotnet new angular6 -n <name_of_your_project>
1. Open src/YourProject from a console and run:
	1.- npm isntall
	1.- npm install node-sass
	1.- npm install @angular/cli
	1.- ng build
1. Open the solution and then go to your project properties
1. In Build section mark XML documentation file (needed for Swagger documentation)
1. Run it.
1. **Enjoy coding!**

### Hints
HMR has changes and does not work as before when we mix .Net Core and Angular 6, The Host only serves static files.
At the time being the web application is not being refreshed (not --HMR) so if you want to refresh the application just open a console in the application root folder and run 'ng build', once it finish refresh your browser and you'll see the changes in the client.

## Swagger instructions

https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?tabs=visual-studio-code

