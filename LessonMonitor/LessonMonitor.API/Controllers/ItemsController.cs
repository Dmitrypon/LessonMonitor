using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LessonMonitor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        public ItemsController()
        {
            
        }

        [HttpGet]
        public Item[] Get(string itemName)
        {
            var random = new Random();
            var items = new List<Item>();

            for (int i = 0; i < 10; i++)
            {
                var item = new Item();

                item.Name = itemName + i;
                item.Id = random.Next(100, 1000);

                items.Add(item);
            }
            return items.ToArray();
        }
        }
    }

