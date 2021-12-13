using System;
using Warehouse.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Warehouse.Dtos;

namespace Warehouse.Repositories
{

    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task CreateItemAsync(Item item);
        Task UpdateItem(Item item);
        Task DeleteItem(Guid id);
    }

}