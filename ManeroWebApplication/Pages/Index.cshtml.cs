using DataAccess.Contexts;
using DataAccess.Handlers.Repositories;
using DataAccess.Models;
using DataAccess.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManeroWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly LocalContext _context; // Använd din faktiska kontextklass
        private readonly ProductRepository _productRepository;

        public IndexModel(ILogger<IndexModel> logger, LocalContext context, ProductRepository productRepository)
        {
            _logger = logger;
            _context = context;
            _productRepository = productRepository;
        }

        public List<Product> BestSellers { get; set; }

        public async Task OnGet()
        {
            _productRepository.GetAllAsync(x => x.ProductPrice < 900);

           // Expression<Func<ProductEntity, bool>> expression = p => p.ProductPrice < 1000;

            BestSellers = await _context.Products
                .Where(expression)
                .Select(p => new Product
                {
                    ProductName = p.ProductName,
                    ProductDescription = p.ProductDescription,
                    ProductPrice = p.ProductPrice,
                    Rating = p.Rating ?? 0,
                    Quantity = p.Quantity ?? 0
                })
                .ToListAsync();
        }
    }
}