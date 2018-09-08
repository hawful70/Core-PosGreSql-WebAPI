# Entity Framework 6 For PostgreSQL

## Using components

* use **Npgsql**
* use **EntityFramework6.Npgsql**


## Installation component

	Install-Package Npgsql

&

	Install-Package EntityFramework6.Npgsql


## 1. Code First For PostgreSQL


### Web.config

	<connectionStrings>
		<add name="PosGreSqlDbContext"
	       connectionString="Server=localhost;Port=5432;Database=DBPosGreSql;User Id=postgres;Password=dev123;;SearchPath=public;" 			providerName="Npgsql" />
	</connectionStrings>

&

	<entityFramework>
        <defaultConnectionFactory type="System.Data.Entity.Infrastructure.LocalDbConnectionFactory, EntityFramework">
            <parameters>
                <parameter value="mssqllocaldb" />
            </parameters>
        </defaultConnectionFactory>
        <providers>
            <provider invariantName="System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer" />
            <provider invariantName="Npgsql" type="Npgsql.NpgsqlServices, EntityFramework6.Npgsql" />
        </providers>
    </entityFramework>

&

	<system.data>
        <DbProviderFactories>
            <remove invariant="Npgsql" />
            <add name="Npgsql Data Provider" invariant="Npgsql" support="FF" description=".Net Framework Data Provider for Postgresql" type="Npgsql.NpgsqlFactory, Npgsql" />
        </DbProviderFactories>
    </system.data>
    
## 2. Use without Migration
	
	The default database initalizer is CreateDatabaseIfNotExists. 
	It will automatically create the database if one does not exist 		
	and it will also enable database migration. To turnoff off migration

	Run the PostgreSQLIdentity.sql script to create the identity tables in your postgreSQL database. 
	We have to do this since the 		
	identity tables will not be created automatically.
	Set the database initalizer to NullDatabaseInitializer to turn off migration.
