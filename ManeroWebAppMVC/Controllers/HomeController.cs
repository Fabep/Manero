using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ManeroWebAppMVC.Controllers
{
	public class HomeController : Controller
	{	
		private readonly IProductService _productService;

		public HomeController(IProductService productService)
		{
			_productService = productService;
		}

        public async Task<IActionResult> Index()
        {
            var bestSellersProductList = await _productService.GetBestSellersAsync();
            var featuredProductList = await _productService.GetFeaturedProductsAsync();

            // Apply the discount logic
            foreach (var product in bestSellersProductList.Concat(featuredProductList))
            {
                if (product.Promotion != null)
                {
                    product.DiscountedPrice = product.ProductPrice * (1 - product.Promotion.DiscountRate);
                }
                else
                {
                    product.DiscountedPrice = product.ProductPrice; // No discount, so set it to the original price
                }
            }

            var viewModel = new HomeViewModel()
            {
                BestSellers = bestSellersProductList.ToList(),
                FeaturedProducts = featuredProductList.ToList()
            };

            return View(viewModel);
        }


        public IActionResult Privacy()
		{
			return View();
		}


	}
}