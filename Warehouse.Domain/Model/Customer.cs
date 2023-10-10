﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Domain.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }
        public string? CEOName { get; set; }
        public string? CEOLastName { get; set; }
        public bool IsActive { get; set; }
        public byte[]? LogoPic { get; set; }

        public CustomerContactInformation CustomerContactInformation { get; set; }

        public virtual ICollection<ContactDetail> ContactDetails { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
