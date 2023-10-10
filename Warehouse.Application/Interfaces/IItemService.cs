using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.ViewModels.Items;
using Warehouse.Domain.Model;

namespace Warehouse.Application.Interfaces
{
    public interface IItemService
    {
        ListItemForListVm GetAllItems();
    }
}
