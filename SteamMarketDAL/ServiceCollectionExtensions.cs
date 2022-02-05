using Microsoft.Extensions.DependencyInjection;

namespace SteamMarketDAL
{
    public static class ServiceCollectionExtensions
    {
        public static void AddSteamMarketRepositories(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddTransient<IItemsRepository>(x => new ItemsRepository(connectionString));
        }
    }
}
