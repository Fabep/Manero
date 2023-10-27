using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManeroWebApplication.Pages.Products
{
    public class ArticleModel : PageModel
    {
        private readonly ProductRepository _productRepository;
        public ArticleModel(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product Product { get; set; } = null!;
        public int ReviewCount { get; set; } = 0;
        [BindProperty]
        public int CurrentAmount { get; set; } = 0; 
        public async Task OnGetAsync(Guid id)
        {
            Product = DataConverter.ConvertProductEntityToProduct(
                await _productRepository.GetAsync(x => x.ProductId == id));
        }
    }
}
