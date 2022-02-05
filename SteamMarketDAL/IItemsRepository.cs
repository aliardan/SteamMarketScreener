using SteamMarketDAL.Models;

namespace SteamMarketDAL
{
    public interface IItemsRepository
    {
        public Item GetByName(string itemName);

        public void Add(Item item);
    }
}
