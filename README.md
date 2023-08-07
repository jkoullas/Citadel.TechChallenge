# Citadel Developer Technical Challenge

The following solution consists of a simple ASP.NET web application, and an ASP.NET CORE API application

On the website :
- The user can enter their name into a form on the website
- The user can click a submit button on the website
- The input is validated and will return an error if the name field is empty
- The website submits the value to an API

The API receives the value and:
-Stores the value into the data store (memory)
- Outputs to a log "Received request from <Name>" where <Name> is the value sent to the API
- The API returns a success response code to the website
- The website displays "Thank you 'Your Name' when it receives a successful response


# Developer Notes

Open the solution in Visual Studio 2022.

There are no external dependecies required to run the project locally.  Simply open the project and restore all Nuget packages.
The API project uses an In-Memory database with Entity Framework.

Set the following 2 projects to start up:
- Citadel.API
- Citadel.Web

Run the solution.  This will spawn 2 browser windows. One for the API Swagger documentation, and the other for the website

The web project is a simple MVC project which uses:
- jquery
- bootstrap
  
The following are notable Nuget packages are used in the API project.  
- Entity Framework
- Fluent Validation
- Microsoft.Extentions.Logging
- Microsoft.Extentions.Configuration
- xunit
- Moq
