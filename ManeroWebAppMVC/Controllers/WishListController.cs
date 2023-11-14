using DataAccess.Handlers.Services;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ManeroWebAppMVC.Controllers
{
	public class WishListController : Controller
	{

		private readonly IProductService _productService;
		public WishListController(IProductService productService)
		{
			_productService = productService;
		}
		public IActionResult Index()
		{
			var viewModel = new WishListViewModel();

			//viewModel.Products = _productService.AddProductToWishList();
			//viewModel.Products = _productService.DeleteProductFromWishList();

			return View(viewModel);
		}

       



    }
}
