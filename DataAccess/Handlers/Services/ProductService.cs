using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Services
{
	public class ProductService : IProductService
	{
		private readonly ProductRepository _productRepository;

		public ProductService(ProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		public async Task<List<Product>> GetBestSellersAsync()
		{
			var productList = await _productRepository.GetAllAsync(x => x.ProductPrice < 900);
			var products = new List<Product>();

			foreach (var productEntity in productList)
			{
				var product = DataConverter.ConvertProductEntityToProduct(productEntity);

				if (ShouldHavePromotion(productEntity))
				{
					product.Promotion = GetPromotion();
				}

				products.Add(product);
			}

			return products;
		}

		public async Task<List<Product>> GetFeaturedProductsAsync()
		{
			var featuredProductList = await _productRepository.GetAllAsync(x => x.ProductPrice < 1000);
			var products = new List<Product>();

			foreach (var productEntity in featuredProductList)
			{
				var product = DataConverter.ConvertProductEntityToProduct(productEntity);

				if (ShouldHavePromotion(productEntity))
				{
					product.Promotion = GetPromotion();
				}

				products.Add(product);
			}

			return products;
		}

		public bool ShouldHavePromotion(ProductEntity product)
		{
			return product.ProductPrice < 400;
		}

		public Promotion GetPromotion()
		{
			var promotion = new Promotion
			{
				PromotionId = Guid.NewGuid(),
				Name = "Special Discount",
				Description = "10% off on selected products",
				DiscountRate = 0.10,
				StartDate = DateTime.Now,
				EndDate = DateTime.Now.AddMonths(1)
			};

			return promotion;
		}
	}

}
