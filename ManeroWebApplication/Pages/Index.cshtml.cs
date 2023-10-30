using DataAccess.Contexts;
using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManeroWebApplication.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ProductRepository _productRepository;
        private readonly IProductService _productService;

		public IndexModel(ProductRepository productRepository, IProductService productService)
		{
			_productRepository = productRepository;
			_productService = productService;
		}

		public List<DataAccess.Models.Product> BestSellers { get; set; }
        public List<DataAccess.Models.Product> FeaturedProducts { get; set; }

        public async Task OnGet()
        {


            var productList = await _productRepository.GetAllAsync(x => x.ProductPrice < 900);
            var featuredProductList = await _productRepository.GetAllAsync(x => x.ProductPrice < 1000);

            BestSellers = productList
             .Select(p => DataConverter.ConvertProductEntityToProduct(p))
             .ToList();


            //BestSellers = productList
            //    .Select(p => new DataAccess.Models.Product
            //    {
            //        ProductName = p.ProductName,
            //        ProductDescription = p.ProductDescription,
            //        ProductPrice = p.ProductPrice,
            //        Rating = p.Rating ?? 0,
            //        Quantity = p.Quantity ?? 0
            //    })
            //    .ToList();

            FeaturedProducts = featuredProductList
                .Select(p => DataConverter.ConvertProductEntityToProduct(p))
                //{
                //    ProductName = p.ProductName,
                //    ProductDescription = p.ProductDescription,
                //    ProductPrice = p.ProductPrice,
                //    Rating = p.Rating ?? 0,
                //    Quantity = p.Quantity ?? 0
                //})
                .ToList();
        }
    }
}