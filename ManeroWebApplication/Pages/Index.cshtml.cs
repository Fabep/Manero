using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManeroWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
           
        }
        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = new List<Product>
            {
                new Product
                {
                    ProductName = "Cool tröja",
                    ProductDescription = "Description",
                    ProductPrice = 100,
                    Quantity = 1,
                    Rating = 3
                }
            };

        }
    }
}