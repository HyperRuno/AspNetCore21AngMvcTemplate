# AspNetCore2Ang6Template
This project solves the lack of an Angular 6 based ASP NET Core project template in Visual Studio

### Install from the git repo

1. Git clone this repo
1. Install the template `dotnet new --install .\content`
1. Create a directory where you would like to store the project
1. type `dotnet new Core2Angular6 -n <name_of_your_project>
1. cd into your project and open the solution
1. **Enjoy coding!**

### Update Angular CLI
1. npm uninstall -g angular-cli
1. npm cache clean --force 
1. npm install -g @angular/cli@latest

### Hints
This template is using static files, during build time it runs 'ng build' so the ASP NET Core application serves the wwwroot content, at the time being the web application is not being refreshed (not --HMR) so if you want to refresh the application just open a console in the application root folder and run 'ng build', once it finish refresh your browser.

## Swagger instructions

https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?tabs=visual-studio-code

