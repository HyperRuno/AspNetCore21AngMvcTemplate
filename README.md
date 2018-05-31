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

### Install from the git repo

1. Git clone this repo
1. Install the template `dotnet new --install .\content`
1. Create a directory where you would like to store the project
1. Type `dotnet new angular6 -n <name_of_your_project>
1. Open the solution and run the project
1. **Enjoy coding!**

(NOTE: VS should install all node dependencies for you but you might have to run manually 'npm install' if there are unresolved dependencies.)

### Update Angular CLI
1. npm uninstall -g angular-cli
1. npm cache clean --force 
1. npm install -g @angular/cli@latest

### Hints
HMR has changes and does not work as before when we mix .Net Core and Angular 6, The Host only serves static files.
At the time being the web application is not being refreshed (not --HMR) so if you want to refresh the application just open a console in the application root folder and run 'ng build', once it finish refresh your browser and you'll see the changes in the client.

## Swagger instructions

https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?tabs=visual-studio-code

