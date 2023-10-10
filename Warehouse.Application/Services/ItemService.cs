using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Interfaces;
using Warehouse.Application.ViewModels.Customer;
using Warehouse.Application.ViewModels.Items;
using Warehouse.Domain.Interfaces;
using Warehouse.Domain.Model;

namespace Warehouse.Application.Services
{
    public class ItemService :IItemService
    {
        private readonly IItemRepository _itemRepo;
        public ItemService(IItemRepository itemRepo)
        {
            _itemRepo = itemRepo;
        }
        public ListItemForListVm GetAllItems()
        {
            var items = _itemRepo.GetAllItems().ToList();
            var itemsToShow = new ListItemForListVm();
            itemsToShow.Items = new List<ItemForListVm>();
            foreach (var item in items)
            {
                var add = new ItemForListVm()
                {
                    Id = item.Id,
                    Name = item.Name,
                    TypeName = item.Type.Name
                };

                itemsToShow.Items.Add(add);
            }
            return itemsToShow;
        }
    }
}
