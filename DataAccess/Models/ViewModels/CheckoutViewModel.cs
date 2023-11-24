using DataAccess.Models.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.ViewModels
{
    public class CheckoutViewModel
    {
        public OrderSchema Order { get; set; }
        public string DeliveryFee { get; set; } = "Free";
        public string? UserComment { get; set; }
        public string? OrderDataJson { get; set; }
    }
}
