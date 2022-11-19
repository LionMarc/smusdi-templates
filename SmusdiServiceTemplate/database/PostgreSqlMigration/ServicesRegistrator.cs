using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shared;
using Smusdi.Core.Extensibility;

internal class ServicesRegistrator : IServicesRegistrator
{
    public IServiceCollection Add(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MigrationDbContext>(optionsBuilder => optionsBuilder
            .UseNpgsql(configuration.GetConnectionString("postgresql"), x => x.MigrationsHistoryTable("__ef_migrations_history", Constants.DatabaseSchema))
            .UseSnakeCaseNamingConvention());

        return services;
    }
}
