using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Mapping;

namespace Warehouse.Application.ViewModels.Customer
{
    public class CustomerForListVm : IMapFrom<Warehouse.Domain.Model.Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIP { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Warehouse.Domain.Model.Customer, CustomerForListVm>();
        }
    }
}
