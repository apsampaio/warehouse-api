using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Warehouse.Entities;
using Warehouse.Database;
using Microsoft.EntityFrameworkCore;

namespace Warehouse.Repositories
{
    public class ItemsRepository : IItemsRepository
    {

        private readonly SQLiteContext dbContext = new SQLiteContext();

        public async Task CreateItemAsync(Item item)
        {
            await this.dbContext.items.AddAsync(item);
            await this.dbContext.SaveChangesAsync();
        }

        public Task DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Item> GetItemAsync(Guid id)
        {
            return await this.dbContext.items.FindAsync(id);
        }

        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            var items = await this.dbContext.items.ToListAsync();
            return items;
        }

        public Task UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}