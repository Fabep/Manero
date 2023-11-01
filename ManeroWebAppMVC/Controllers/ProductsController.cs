using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
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
				ProductList = await _productService.GetProductsFromSubCategoryAsync(subProductCategory)
			};

			return View(viewModel);
		}


		public async Task<IActionResult> Article(Guid id)
		{

			var viewModel = new ArticleViewModel
			{
				Product = await _productService.GetOneProductFromIdAsync(id),

                //Product = DataConverter.ConvertProductEntityToProduct(await _productRepository.GetAsync(x => x.ProductId == id)),
            };

			return View(viewModel);
		}


	}
}
