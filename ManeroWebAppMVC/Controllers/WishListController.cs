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

        public async Task<IActionResult> AddToWishList(string productName, int currentAmount, string selectedSize, string selectedColor)
		{
            try
            {
                Product product = await _productService.FindProduct(productName, selectedSize, selectedColor);
                var cartObject = new ProductCartObject
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = (decimal)product.ProductPrice,
                    Size = selectedSize,
                    Color = selectedColor,
                    Quantity = currentAmount,
                    ImageUrl = product.ImageUrl
                };

                var viewModel = new WishListViewModel();
                viewModel.Products.Add(cartObject);
                    
                    //Product = product,
                    //Combinations = await _productService.GetProductColorsAndSizesAsync(product.ProductName)
                

            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return RedirectToAction("Article", new { n = productName });

        }



    }
}
