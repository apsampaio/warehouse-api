using System;
using Warehouse.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Warehouse.Dtos;

namespace Warehouse.Repositories
{

    public interface IItemsRepository
    {
        Task<Item> GetItemAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task CreateItemAsync(Item item);
        Task UpdateItemAsync(Item item, Item updatedItem);
        Task DeleteItemAsync(Item item);
    }

}