using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Domain.Interfaces;
using Warehouse.Domain.Model;
using Type = Warehouse.Domain.Model.Type;

namespace Warehouse.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly Context _context;
        public ItemRepository(Context context)
        {
            _context = context;
        }

        public void DeleteItem(int itemId)
        {
            var item = _context.Items.Find(itemId);
            if(item != null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
        }

        public int AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public IQueryable<Item> GetItemsByTypeId(int typeId)
        {
            var items = _context.Items.Where(i => i.TypeId == typeId);
            return items;
        }

        public Item GetItemById(int itemid)
        {
            var item = _context.Items.FirstOrDefault(i => i.Id == itemid);
            return item;
        }


        public IQueryable<Tag> GetAllTags()
        {
            var tags = _context.Tags;
            return tags;
        }

        public IQueryable<Type> GetAllTypes()
        {
            var types = _context.Types;
            return types;
        }

        public List<Item> GetAllItems()
        {
            var items = _context.Items.ToList();
            for (int i = 0; i < items.Count(); i++)
            {
                var types = this.GetAllTypes();
                var typeId = items[i].TypeId;
                items[i].Type = types.FirstOrDefault(t => t.Id == typeId);
            }
            return items;
        }
    }
}
