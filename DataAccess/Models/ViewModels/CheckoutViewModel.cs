using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.ViewModels
{
    public class CheckoutViewModel
    {
        public decimal TotalOrderSum { get; set; } = 0;
        public List<CheckOutArticleViewModel>? Products { get; set; } = new List<CheckOutArticleViewModel>();
        public decimal OrderDiscount { get; set; } = 0;
        public string DeliveryFee { get; set; } = "Free";
        public string? ShippingDetails { get; set; }
        public string? PaymentMethod { get; set; }
        public string? UserComment { get; set; }
    }
}
