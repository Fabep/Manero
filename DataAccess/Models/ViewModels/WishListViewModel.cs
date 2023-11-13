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
        public List<ProductCartObject> Products { get; set; } = new List<ProductCartObject>();

        // new ProductCartObject
                //ProductId = new Guid(),
                //ProductName = "Green Skirt",
                //ProductPrice = 100,
                //ProductDescription = "laflaf",
                //DiscountedPrice = 75,
                //Rating = 4,
                //Quantity = 1,       
    }
}
