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


# API
Open the solution in Visual Studio 2022.

There are no external dependecies required to run the project locally.  Simply open the project and restore all Nuget packages.
The API project uses an In-Memory database with Entity Framework.

Set the following project to start up:
- Citadel.API

Run the solution.  This will spawn a browser windows with the API Swagger documentation.

The following are notable Nuget packages are used in the API project.  
- Entity Framework
- Fluent Validation
- Microsoft.Extentions.Logging
- Microsoft.Extentions.Configuration
- xunit
- Moq

Note: The solution also contains an ASP.NET web project.  It is a simple MVC project which can be used to test the API.
  
# Web

The front end is a React web application.  To run the application:

- Ensure you have Node installed
- Open the folder "citadel-react" in Visual Studio code
- Open a terminal window and browse to the web folder "citadel-react"
- Ensure the API is running as per above
- Run "npm start" and the website will launch at address http://localhost:3000/

