using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.ViewModels
{
    public class WishListViewModel
    {
        public string PageTitle { get; set; } = "Wish list";
        public List<Product> Products { get; set; } = new List<Product>
        {
            new Product
            {
                ProductId = new Guid(),
                ProductName = "Yellow Skirt",
                ProductPrice = 100,
                ProductDescription = "lahfjlaf",
                DiscountedPrice = 75,
                Rating = 4,
                Quantity = 1,

            }
        };
    }
}
