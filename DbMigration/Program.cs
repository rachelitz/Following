using DbMigration;
using Microsoft.Extensions.Configuration;

var environment =
    Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT")
    ?? "Production";

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false)
    .AddJsonFile($"appsettings.{environment}.json", optional: true)
    .AddEnvironmentVariables()
    .Build();

var connectionString = configuration.GetConnectionString("DefaultConnection");

if (string.IsNullOrWhiteSpace(connectionString))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Connection string 'DefaultConnection' was not found.");
    Console.ResetColor();

    return -1;
}

return new DbMigrator(connectionString).Run();