# PostgreSQL.AspNet.Identity.EntityFramework

ASP.NET Identity 2.0 provider that use Entity Framework for PostgreSQL.

## How to use in a ASP.NET MVC5 template project

### 1. Update the project to use PostgreSQL.AspNet.Idnetity.EntityFramework
Once you have correctly setup the PostgreSQL EntityFramework, using PostgreSQL.AspNet.Identity.Framework is straight forward.

1. Add the PostgreSQL.AspNet.Identity.EntityFramework project as a reference
2. Remove the Microsoft.AspNet.Identity.EntityFramework nuget package and replace the "using Microsoft.AspNet.Identity.EntityFramework" statements with "using PostgreSQL.AspNet.Identity.EntityFramework" (it's in IdentityModel.cs and IdentityConfig.cs in the default mvc5 project template)
   
### 2. Use without Migration
The default database initalizer is CreateDatabaseIfNotExists. It will automatically create the database if one does not exist and it will also enable database migration. To turnoff off migration

1. Run the PostgreSQLIdentity.sql script to create the identity tables in your postgreSQL database. We have to do this since the identity tables will not be created automatically.
2. Set the database initalizer to NullDatabaseInitializer to turn off migration.

```csharp
// put this in the project startup 
Database.SetInitializer<ApplicationDbContext>(new NullDatabaseInitializer<ApplicationDbContext>());
```
## References
* This is a port of the [ASPNET Identity for SQL Server](https://aspnetidentity.codeplex.com/). 
* This project got a jump start from [AspNet.Identity.PostgreSQL](https://github.com/danellos/AspNet.Identity.PostgreSQL)

## LICENSE
[MIT](/LICENSE)
