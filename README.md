## Migrations

Detail is here-

	http://www.bricelam.net/2014/09/14/migrations-on-k.html

And here-

	https://docs.efproject.net/en/latest/platforms/netcore/new-db-sqlite.html#use-your-model

### Commands-

Creating-

	dotnet ef migrations add MyFirstMigration
	dotnet ef database update

With more than 1 DB context-

	dotnet ef migrations add MyFirstMigration -c CoreFullTest.Model.McpDbContext
	dotnet ef database update -c CoreFullTest.Model.McpDbContext

All commands should be run under `.\src\<ProjectFolder>`.