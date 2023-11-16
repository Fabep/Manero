using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class OrderObject
    {
        public List<ProductCartObject> Items { get; set; } = null!;
        public double TotalAmount { get; set; }
        public double PromotionDiscount { get; set; }

    }
}
