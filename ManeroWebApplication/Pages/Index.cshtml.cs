using DataAccess.Contexts;
using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ManeroWebApplication.Pages
{
	public class IndexModel : PageModel
	{
		private readonly IProductService _productService;

		public IndexModel(IProductService productService)
		{
			_productService = productService;
		}

		public List<DataAccess.Models.Product> BestSellers { get; set; } = new List<Product>();
		public List<DataAccess.Models.Product> FeaturedProducts { get; set; } = new List<Product>();

		public async Task OnGet()
		{
			BestSellers = await _productService.GetBestSellersAsync();
			FeaturedProducts = await _productService.GetFeaturedProductsAsync();
			foreach (var product in BestSellers.Concat(FeaturedProducts))
			{
				if (product.Promotion != null)
				{
					product.DiscountedPrice = product.ProductPrice * (1 - product.Promotion.DiscountRate);
				}
				else
				{
					product.DiscountedPrice = product.ProductPrice; // No discount, so set it to the original price
				}

			}
		}
	}
	}

