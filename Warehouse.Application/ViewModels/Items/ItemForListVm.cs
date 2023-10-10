using System.ComponentModel;

namespace Warehouse.Application.ViewModels.Items
{
    public class ItemForListVm
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Type")]
        public string TypeName { get; set; }
    }
}
