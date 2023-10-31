using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;

namespace ManeroWebAppMVC.Controllers
{
	public class ProductsController : Controller
	{
		private readonly IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}


		public async Task<IActionResult> Index(string subProductCategory)
		{

			var viewModel = new ProductsViewModel
			{
				PageTitle = subProductCategory,
				ProductList = await _productService.GetProductsFromSubCategory(subProductCategory)
			};

			return View(viewModel);
		}
	}
}
