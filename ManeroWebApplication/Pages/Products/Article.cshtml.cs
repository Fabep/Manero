using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;

namespace ManeroWebApplication.Pages.Products
{
    public class ArticleModel : PageModel
    {
        private readonly IProductService _productService;
        public ArticleModel(IProductService productService)
        {
            _productService = productService;
        }
        [BindProperty(SupportsGet = true)]
        public double DiscountedPrice { get; set; }
		public Product Product { get; set; } = null!;
        public int ReviewCount { get; set; } = 0;
        [BindProperty]
        public int CurrentAmount { get; set; } = 0;
		public async Task OnGetAsync(Guid id, double discountedPrice)
		{
			Product = DataConverter.ConvertProductEntityToProduct(
				await _productRepository.GetAsync(x => x.ProductId == id));

			// Adjust DiscountedPrice to include the decimal point
			DiscountedPrice = discountedPrice / 10.0;
		}



	}
        public int CurrentAmount { get; set; } = 0;

        public List<string> Sizes { get; set; } = new List<string>();
        public List<string> Colors { get; set; } = new List<string>();
        public Dictionary<string, string> Combinations { get; set; }
        
        public async Task OnGetAsync(string n)
        {
            Product = await _productService.GetOneProductFromNameAsync(n);
            Combinations = await _productService.GetProductColorsAndSizesAsync(n);

            foreach(var combination in Combinations)
            {
                Sizes.Add(combination.Key);
                Colors.Add(combination.Value);
            }
        }

        public async Task<IActionResult> OnGetColorPickAsync(string color)
        {
            var temp = Combinations.Where(x => x.Value == color).ToList();
            if (temp.Any())
            {
                Sizes = temp.Select(x => x.Key).ToList();
            }
            return new JsonResult(new {sizes = Sizes});
        }
        public async Task<IActionResult> OnGetSizePickAsync(string size)
        {
            var temp = Combinations.Where(x => x.Key == size);
            if(temp.Any())
            {
                Colors = temp.Select(x => x.Value).ToList();
            }
            return new JsonResult(new {colors = Colors});
        }
    }
}
