using Microsoft.AspNetCore.Mvc;

using Warehouse.Entities;
using Warehouse.Database;

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace Warehouse.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly SQLiteContext dbContext = new SQLiteContext();


        [HttpGet]
        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            var items = await this.dbContext.items.ToListAsync();
            return items;
        }

    }
}