﻿using DataAccess.Enums;
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
		public async Task<IActionResult> Article(string n, SizeEnum? selectedSize = null!, string selectedColor = null! )
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
				Product = product,
				Combinations = await _productService.GetProductColorsAndSizesAsync(n)
			};

			if (viewModel.Combinations is not null)
				_productService.SetSizesAndColors(viewModel, selectedSize, selectedColor);
			return View(viewModel);
		}
      




        [HttpPost]
		public async Task<IActionResult> AddProduct(int currentAmount, string productName, string selectedSize, string selectedColor, decimal? discountPrice)
		{
			try
			{
				Product product = await _productService.FindProduct(productName, selectedSize, selectedColor);
                if (product == null) return RedirectToAction("Article", new { n = productName });

                var cartObject = new ProductCartObject
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = product.ProductPrice,
                    Size = selectedSize,
                    Color = selectedColor,
                    Quantity = currentAmount,
                    ImageUrl = product.ImageUrl,
                    DiscountedPrice = discountPrice ?? 0
                };

                var productCookie = _cookieService.GetCookie(Request, "ProductsCookie");

                if (productCookie is null)
                {
                    _cookieService.AddCookie(Response, "ProductsCookie", new List<ProductCartObject> { cartObject });
                }
                else
                {
                    var cartList = JsonConvert.DeserializeObject<List<ProductCartObject>>(_cookieService.GetCookie(Request, "ProductsCookie")!);
                    if (cartList!.Select(x => x.ProductId).Contains(cartObject.ProductId))
                    {
                        cartList.FirstOrDefault(x => x.ProductId == cartObject.ProductId)!.Quantity += cartObject.Quantity;
                    }
                    else
                    {
                        cartList!.Add(cartObject);
                    }

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


        public async Task<IActionResult> Search(string query)
        {
            var searchResults = await _productService.SearchProductsAsync(query);

            var viewModel = new SearchViewModel
            {
                Query = query,
                Results = searchResults
            };

            return View(viewModel);
        }





        public IActionResult Filter(string color, decimal? minPrice, decimal? maxPrice, string subCategory, string size)
        {
            var filterResults = _productService.GetFilteredProducts(color, minPrice, maxPrice, subCategory, size);

            var viewModel = new SearchViewModel
            {
                Query = $"Color: {color}, SubCategory: {subCategory}, MinPrice: {minPrice}, MaxPrice: {maxPrice} Size: {size}",
                Results = filterResults // Hämta resultatet från Task
            };

            return View(viewModel);
        }







    }

}
