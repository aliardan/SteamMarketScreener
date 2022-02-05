using Microsoft.AspNetCore.Mvc;
using SteamMarketDAL;
using SteamMarketDAL.Models;
using System.ComponentModel;

namespace SteamMarketScreener.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemsController(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        [HttpPost]
        public ActionResult Add(Item item)
        {
            _itemsRepository.Add(item);

            return new StatusCodeResult(200);
        }

        [HttpGet]
        public ActionResult<Item> Get([DefaultValue("TestItemName")] string itemName)
        {
            var item = _itemsRepository.GetByName(itemName);

            if (item == null)
            {
                return new NotFoundResult();
            }

            return item;
        }
    }
}
