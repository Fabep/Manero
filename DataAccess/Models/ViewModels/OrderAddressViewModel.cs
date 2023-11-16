using DataAccess.Models.Entities;
using DataAccess.Models.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.ViewModels
{
    public class OrderAddressViewModel
    {
        public OrderSchema? Order { get; set; }
        public string? AddressType { get; set; }
        public List<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();
    }
}
