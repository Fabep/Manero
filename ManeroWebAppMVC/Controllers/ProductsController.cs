using DataAccess.Enums;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace ManeroWebAppMVC.Controllers
{
    public class ProductsController : Controller
	{
		private readonly IProductService _productService;
		private readonly ICookieService _cookieService;

        public ProductsController(IProductService productService, ICookieService cookieService)
        {
            _productService = productService;
            _cookieService = cookieService;
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
			try
			{
				Product product = await _productService.FindProduct(productName, selectedSize, selectedColor);
                var cartObject = new ProductCartObject
                {
					ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = (decimal)product.ProductPrice,
                    Size = Enum.Parse<SizeEnum>(selectedSize),
                    Color = selectedColor,
                    Quantity = currentAmount
                };

                var productCookie = _cookieService.GetCookie(Request, "ProductsCookie");

                if (productCookie is null)
                {
                    _cookieService.AddCookie(Response, "ProductsCookie", new List<ProductCartObject> { cartObject });
                }
                else
                {
                    var cartList = JsonConvert.DeserializeObject<List<ProductCartObject>>(_cookieService.GetCookie(Request, "ProductsCookie")!);

                    cartList!.Add(cartObject);

                    _cookieService.AddCookie(Response, "ProductsCookie", cartList);
                }

                var viewModel = new ArticleViewModel
                {
                    Product = product,
                    Combinations = await _productService.GetProductColorsAndSizesAsync(product.ProductName)
                };

            }
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
            return RedirectToAction("Article", new { n = productName });
			
		}
	}
}
