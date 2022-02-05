using SteamMarketDAL.Models;
using Dapper;
using System.Data.SqlClient;
using System.Linq;

namespace SteamMarketDAL
{
    internal class ItemsRepository : IItemsRepository
    {
        private readonly string _connectionString;

        public ItemsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Item item)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "INSERT INTO dbo.Item(Id, Name) VALUES (@Id, @Name)";
                connection.Execute(query, item);
            }
        }

        public Item GetByName(string itemName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM dbo.Item WHERE Name = @ItemName";
                var item = connection.Query<Item>(query, new { ItemName = itemName }).FirstOrDefault();
                return item;
            }
        }
    }
}
