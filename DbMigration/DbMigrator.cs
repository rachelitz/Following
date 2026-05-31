using DbUp;
using System.Reflection;

namespace DbMigration;

public sealed class DbMigrator(string connectionString)
{
    public int Run()
    {
        try
        {
            // יוצר את ה-DB בשרת אם הוא עדיין לא קיים
            EnsureDatabase.For.SqlDatabase(connectionString);

            var upgrader = DeployChanges.To
                .SqlDatabase(connectionString)
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                .WithTransactionPerScript() // מבטיח שכל סקריפט ירוץ בטרנזקציה (הכל או כלום)
                .LogToConsole()
                .Build();

            Console.WriteLine("Scanning for pending migrations...");

            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Migration failed!");
                Console.WriteLine(result.Error);
                Console.ResetColor();
                return -1;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success! Database is up to date.");
            Console.ResetColor();
            return 0;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            Console.ResetColor();
            return -1;
        }
    }
}