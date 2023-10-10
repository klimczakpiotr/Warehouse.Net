using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Application.Mapping;

namespace Warehouse.Application.ViewModels.Customer
{
    public class NewCustomerVm : IMapFrom<Warehouse.Domain.Model.Customer>
    {
        public int Id { get; set; }
        [DisplayName("Nazwa")]
        [Required]
        public string Name { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewCustomerVm, Warehouse.Domain.Model.Customer>().ReverseMap();
        }
    }

    public class NewCustomerValidation : AbstractValidator<NewCustomerVm>
    {
        public NewCustomerValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.NIP).Length(10);
            RuleFor(x => x.REGON).Length(9, 14);
            RuleFor(x => x.Name).MaximumLength(255);
        }
    }
}
