using DataAccess.Enums;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

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


		public async Task<IActionResult> Article(string n, SizeEnum? selectedSize = null!, string selectedColor = null! )
		{
			
			var viewModel = new ArticleViewModel
			{
				Product = await _productService.GetOneProductFromNameAsync(n),
				Combinations = await _productService.GetProductColorsAndSizesAsync(n)
			};

			if (viewModel.Combinations is not null)
				_productService.SetSizesAndColors(viewModel, selectedSize, selectedColor);
			return View(viewModel);
		}


		[HttpPost]
		public async Task<IActionResult> AddProduct(int currentAmount, string productName, string selectedSize, string selectedColor)
		{
			Product product = await _productService.FindProduct(productName, selectedSize, selectedColor);

			
			return View("Article");
		}
	}
}
