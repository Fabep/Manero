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
		private readonly ProductRepository _productRepository;
		private readonly IProductService _productService;

		public HomeController(ProductRepository productRepository, IProductService productService)
		{
			_productRepository = productRepository;
			_productService = productService;
		}

		public async Task<IActionResult> Index()
		{

			var bestSellersProductList = await _productRepository.GetAllAsync(x => x.ProductPrice < 900);
			var featuredProductList = await _productRepository.GetAllAsync(x => x.ProductPrice < 1000);


			var viewModel = new HomeViewModel()
			{
				BestSellers = bestSellersProductList
				.Select(p => DataConverter.ConvertProductEntityToProduct(p))
				.ToList(),

				FeaturedProducts = featuredProductList
				.Select(p => DataConverter.ConvertProductEntityToProduct(p))
				.ToList()
			};


			return View(viewModel);

		}

		public IActionResult Privacy()
		{
			return View();
		}


	}
}