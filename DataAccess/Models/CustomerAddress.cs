using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class CustomerAddress
    {
        public string? AddressName { get; set; }
        public string? StreetAddress { get; set; }
        public string? Streetnumber { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? Country { get; set; }
    }
}
