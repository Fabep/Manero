using DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ProductCartObject
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
        public string Size { get; set; } = null!;
        public string Color { get; set; } = null!;
        public int Quantity { get; set; }
        public string ImageUrl { get; set; } = null!;
    }
}
