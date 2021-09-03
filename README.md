### To build and run the program

* Restore the database using the .bak file located in the project folder
* Change the connection string in appsettings.json

### Code architecture and structure

Developed using repository pattern to create an abstraction layer between the data access and business logic layer. It is a 3-tier application consisting of controller, services, and repositories. The repositories are injected into the services using the built-in dependency injection.

### Test Link

* https://localhost:44315/transactions/1
* https://localhost:44315/transactions/2

### Technologies Used

* ASP.NET CORE WEB API
* EF CORE
* SQL SERVER
