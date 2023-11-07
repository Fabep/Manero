using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ManeroWebAppMVC.Controllers
{
	public class ProductsController : Controller
	{
		private readonly IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}


		public async Task<IActionResult> Index(string subProductCategory, string sortOrder)
		{
			var viewModel = new ProductsViewModel();

			viewModel.SortOrder = sortOrder;


            var productList = new List<Product>();
			try
			{
				if (subProductCategory == "Best Sellers")				
                    productList = await _productService.GetBestSellersAsync();                
				else if (subProductCategory == "Featured Products")
					productList = await _productService.GetFeaturedProductsAsync();
				else
					productList = await _productService.GetProductsFromSubCategoryAsync(subProductCategory);

                productList = _productService.GetSortedListOfProducts(sortOrder, productList);
            }
			catch (Exception ex) { Debug.WriteLine(ex.Message); }

			viewModel.PageTitle = subProductCategory;
			viewModel.ProductList = productList;

			return View(viewModel);
		}




		public async Task<IActionResult> Article(string n)
		{
            var product = await _productService.GetOneProductFromNameAsync(n);

            // Apply the discount logic
            if (product.Promotion != null)
            {
                product.DiscountedPrice = product.ProductPrice * (1 - product.Promotion.DiscountRate);
            }
            else
            {
                product.DiscountedPrice = product.ProductPrice; 
            }

			var viewModel = new ArticleViewModel
			{
				Product = await _productService.GetOneProductFromNameAsync(n),
				Combinations = await _productService.GetProductColorsAndSizesAsync(n)
			};
			if (viewModel.Combinations is not null)
			{
				foreach (var combination in viewModel.Combinations)
				{
					if (!viewModel.Sizes.Contains(combination.Item1))
						viewModel.Sizes.Add(combination.Item1);
					if (!viewModel.Colors.Contains(combination.Item2))
						viewModel.Colors.Add(combination.Item2);
				}
				viewModel.Sizes.Sort();
			}
			return View(viewModel);
		}
	}

}
