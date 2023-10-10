using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Domain.Model;
using Type = Warehouse.Domain.Model.Type;

namespace Warehouse.Domain.Interfaces
{
    public interface IItemRepository
    {
        List<Item> GetAllItems();
        void DeleteItem(int itemId);

        int AddItem(Item item);

        IQueryable<Item> GetItemsByTypeId(int typeId);

        Item GetItemById(int itemid);


        IQueryable<Tag> GetAllTags();

        IQueryable<Type> GetAllTypes();
    }
}
