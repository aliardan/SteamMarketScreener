using FluentMigrator.Runner;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SteamMarketScreener
{
    public static class MigrateExtensions
    {
        public static IApplicationBuilder Migrate(this IApplicationBuilder applicationBuilder)
        {
            using var scope = applicationBuilder.ApplicationServices.CreateScope();
            var runner = scope.ServiceProvider.GetService<IMigrationRunner>();
            runner.ListMigrations();
            runner.MigrateUp();
            return applicationBuilder;
        }
    }
}
