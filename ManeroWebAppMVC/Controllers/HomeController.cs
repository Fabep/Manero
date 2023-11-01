﻿using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ManeroWebAppMVC.Controllers
{
	public class HomeController : Controller
	{	
		private readonly IProductService _productService;

		public HomeController(IProductService productService)
		{
			_productService = productService;
		}

		public async Task<IActionResult> Index()
		{
			var bestSellersProductList = await _productService.GetBestSellersAsync();
            var featuredProductList = await _productService.GetFeaturedProductsAsync();

            var viewModel = new HomeViewModel()
			{
				BestSellers = bestSellersProductList
				.Select(p => p)
				.ToList(),

				FeaturedProducts = featuredProductList
				.Select(p => p)
				.ToList()
			};


			return View(viewModel);

		}

		public IActionResult Privacy()
		{
			return View();
		}


	}
}