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
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
