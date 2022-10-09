using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

public class MigrationDbContextFactory : IDesignTimeDbContextFactory<MigrationDbContext>
{
    public MigrationDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Environment.GetEnvironmentVariable("SMUSDI_APPSETTINGS_FOLDER"))
            .AddJsonFile("appsettings.json", false, false)
            .Build();

        var connectionString = Environment.ExpandEnvironmentVariables(configuration.GetConnectionString("postgresql"));

        Console.WriteLine($"Using {connectionString}");

        var optionsBuilder = new DbContextOptionsBuilder<MigrationDbContext>();

        // TODO - Replace public schema with your own
        optionsBuilder.UseNpgsql(connectionString, x => x.MigrationsHistoryTable("__EFMigrationsHistory", "public"));

        return new MigrationDbContext(optionsBuilder.Options);
    }
}
