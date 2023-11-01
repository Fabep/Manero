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
		private readonly ProductRepository _productRepository;


		public ProductsController(IProductService productService, ProductRepository productRepository)
		{
			_productService = productService;
			_productRepository = productRepository;
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


		public async Task<IActionResult> Article(Guid id)
		{

			var viewModel = new ArticleViewModel
			{
				Product = DataConverter.ConvertProductEntityToProduct(
				await _productRepository.GetAsync(x => x.ProductId == id)),
			};

			return View(viewModel);
		}


	}
}
