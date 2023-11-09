using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
