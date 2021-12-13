using Microsoft.AspNetCore.Mvc;

using Warehouse.Repositories;
using Warehouse.Entities;
using Warehouse.Database;

using System.Collections.Generic;

namespace Warehouse.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly SQLiteContext dbContext = new SQLiteContext();

        [HttpGet]
        public Item GetItems()
        {
            var items = this.dbContext.Items.Find();
            return items;
        }
    }
}