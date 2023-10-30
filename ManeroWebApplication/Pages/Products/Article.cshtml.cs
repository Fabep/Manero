using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManeroWebApplication.Pages.Products
{
    public class ArticleModel : PageModel
    {
        private readonly IProductService _productService;
        public ArticleModel(IProductService productService)
        {
            _productService = productService;
        }
        public Product Product { get; set; } = null!;
        public int ReviewCount { get; set; } = 0;
        [BindProperty]
        public int CurrentAmount { get; set; } = 0; 

        public Dictionary<string, string> Combinations { get; set; }
        public async Task OnGetAsync(string n)
        {
            Combinations = await _productService.GetProductColorAndSizeCombinationsAsync(n);


        }
    }
}
