using DataAccess.Models.Schemas;

namespace DataAccess.Models.ViewModels
{
    public class OrderViewModel
    {
        public OrderSchema Order { get; set; }

        public string Delivery { get; set; } = "Free";

        public decimal Discount { get; set; }

        public decimal SubTotal { get; set; }

        public string? OrderDataJson { get; set; }

        public List<PromotionCode>? ActivePromotions { get; set; }


    }
}
