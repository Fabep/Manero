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
		private readonly ProductRepository _productRepository;

		public IndexModel(ProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

        public List<Product> BestSellers { get; set; }
        public List<DataAccess.Models.Product> FeaturedProducts { get; set; }

        public async Task OnGet()
        {


            var productList = await _productRepository.GetAllAsync(x => x.ProductPrice < 900);
            var featuredProductList = await _productRepository.GetAllAsync(x => x.ProductPrice < 1000);

            BestSellers = productList
                .Select(p => new Product
                {
                    ProductName = p.ProductName,
                    ProductDescription = p.ProductDescription,
                    ProductPrice = p.ProductPrice,
                    Rating = p.Rating ?? 0,
                    Quantity = p.Quantity ?? 0
                })
                .ToList();

            FeaturedProducts = featuredProductList
                .Select(p => new DataAccess.Models.Product
                {
                    ProductName = p.ProductName,
                    ProductDescription = p.ProductDescription,
                    ProductPrice = p.ProductPrice,
                    Rating = p.Rating ?? 0,
                    Quantity = p.Quantity ?? 0
                })
                .ToList();
        }
    }
}