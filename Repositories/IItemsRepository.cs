using System;
using Warehouse.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Warehouse.Repositories
{

    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Guid id);
    }

}