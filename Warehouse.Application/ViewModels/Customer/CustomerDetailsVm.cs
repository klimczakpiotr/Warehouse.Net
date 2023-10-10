using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Mapping;

namespace Warehouse.Application.ViewModels.Customer
{
    public class CustomerDetailsVm : IMapFrom<Warehouse.Domain.Model.Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }
        [DisplayName("CEO Name")]
        public string CEOFullName { get; set; }
        [DisplayName("First Line of Contact")]
        public string FirsLineOfContactInformation { get; set; }
        public List<AddressForListVm> Addresses { get; set; }
        public List<ContactDetailListVm> Emails { get; set; }
        public List<ContactDetailListVm> PhoneNumbers { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Warehouse.Domain.Model.Customer, CustomerDetailsVm>()
                .ForMember(s => s.CEOFullName, opt => opt.MapFrom(d => d.CEOName + " " + d.CEOLastName))
                .ForMember(s => s.FirsLineOfContactInformation, opt => opt.MapFrom(d => d.CustomerContactInformation.FirstName + " " + d.CustomerContactInformation.LastName))
                .ForMember(s => s.Addresses, opt => opt.Ignore())
                .ForMember(s => s.Emails, opt => opt.Ignore())
                .ForMember(s => s.PhoneNumbers, opt => opt.Ignore());
        }
    }
}
