using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using Warehouse.Entities;
using Warehouse.Dtos;
using Warehouse.Repositories;
using System;
using System.Collections.Generic;


namespace Warehouse.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {

        private readonly IItemsRepository repository;

        public ItemsController(IItemsRepository repository)
        {
            this.repository = repository;
        }

        // POST - /items
        [HttpPost]
        public async Task<ActionResult<Item>> CreateItem(CreateItemDto item)
        {
            Item newItem = new()
            {
                Id = Guid.NewGuid(),
                Name = item.Name,
                Quantity = item.Quantity,
                Type = item.Type,
                Image = item.Image,
                CreatedAt = DateTimeOffset.UtcNow,
                UpdatedAt = DateTimeOffset.UtcNow,
            };

            await this.repository.CreateItemAsync(newItem);
            return CreatedAtAction(nameof(GetItemAsync), new { id = newItem.Id }, item);
        }
        // GET - /items
        [HttpGet]
        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await this.repository.GetItemsAsync();
        }
        // GET - /items/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItemAsync(Guid id)
        {
            var item = await this.repository.GetItemAsync(id);

            if (item is null)
            {
                return NotFound();
            }

            return item;
        }
    }
}