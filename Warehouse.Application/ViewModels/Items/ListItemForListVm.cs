using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.ViewModels.Customer;

namespace Warehouse.Application.ViewModels.Items
{
    public class ListItemForListVm
    {
        public List<ItemForListVm> Items { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public string SearchString { get; set; }
        public int Count { get; set; }
    }
}
