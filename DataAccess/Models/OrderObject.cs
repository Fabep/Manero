using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class OrderObject
    {
        public List<ProductCartObject> Products { get; set; } = null!;
        public decimal TotalAmount { get; set; }
        public decimal PromotionDiscount { get; set; }

    }
}
