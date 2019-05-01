# Person Search Coding Problem

## Business Requirements
- Accept search input
- Display list of people with any part of first or last name matching search text
- Display at least Name, Address, Age, Interests, and Picture
- Either seed data or provide a way to enter users or both
- Simulate slow search and appropriately handle delay
  
## Technical Requirements
- Web application using WebAPI and a front-end JavaScript framework
- ORM framework for data access
- Unit tests for appropriate parts of application
  
## Notes
A simple web app using Angular for the front-end, a Web Api set of services for accessing the database from the front-end and funneling database access through a simple data access layer using Entity Framework Core. 

## Build and Deployment
  The key point in building, running and deployment would be to set the personapi url in the PersonSearch/ClientApp/src/environments/environment.prod.ts (or environment.ts for running from Visual Studio) after deploying the web service (PersonService project). Once this is done, the web app (PersonSearch) can be published or deployed from Visual Studio via the Publish dialog. 
  
  The database can be created and seeded by using the Seed Database functionality in the web app and shouldn't require any additional setup.
