using DataAccess.Enums;
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
        public List<SizeEnum> Sizes { get; set; } = new List<SizeEnum>();
        public List<string> Colors { get; set; } = new List<string>();
        public List<(SizeEnum, string)> Combinations { get; set; }
        
        public async Task OnGetAsync(string n)
        {
            Product = await _productService.GetOneProductFromNameAsync(n);
            Combinations = await _productService.GetProductColorsAndSizesAsync(n);
            if (Combinations is not null)
                foreach(var combination in Combinations)
                {
                    if (!Sizes.Contains(combination.Item1))
                        Sizes.Add(combination.Item1);
                    if (!Colors.Contains(combination.Item2))
                        Colors.Add(combination.Item2);
                }
            Sizes.Sort();
        }

        public async Task<IActionResult> OnGetColorPickAsync(string color)
        {
            var temp = Combinations.Where(x => x.Item2 == color).ToList();
            if (temp.Any())
            {
                Sizes = temp.Select(x => x.Item1).ToList();
            }
            return new JsonResult(new {sizes = Sizes});
        }
        public async Task<IActionResult> OnGetSizePickAsync(string size)
        {
            var temp = Combinations.Where(x => x.Item1 == Enum.Parse<SizeEnum>(size));
            if(temp.Any())
            {
                Colors = temp.Select(x => x.Item2).ToList();
            }
            return new JsonResult(new {colors = Colors});
        }
    }
}
