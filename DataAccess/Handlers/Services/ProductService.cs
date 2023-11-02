using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
				
				Name = "Special Discount",
				Description = "10% off on selected products",
				DiscountRate = 0.10,
				StartDate = DateTime.Now,
				EndDate = DateTime.Now.AddMonths(1)
			};

			return promotion;
		}
    
        public async Task<List<Product>> GetAllBestSellersAsProductsAsync()
        {
            var productList = await _productRepository.GetAllAsync(x => x.ProductPrice > 900);

            return productList
             .Select(p => DataConverter.ConvertProductEntityToProduct(p))
             .ToList();
        }

        public async Task<List<Product>> GetProductsFromSubCategoryAsync(string subProductCategory)
        {
            // vill hämta de produkter som tillhör vald subkategori
            var productList = await _productRepository.GetAllAsync(x => x.GetType() == typeof(ProductEntity));

			return productList.AsQueryable().Include(c => c.SubCategory)
				.Select(p => DataConverter.ConvertProductEntityToProduct(p))
				.ToList();

            //ProductsFromSubCategory = productList
            //	.Select(productList => DataConverter.ConvertProductEntityToProduct(p))
            //	.ToList();
		}
        public async Task<Product> GetOneProductFromNameAsync(string productName)
        {
            return DataConverter.ConvertProductEntityToProduct(await _productRepository.GetAsync(x => x.ProductName == productName));
        }

		public async Task<Product> GetOneProductFromIdAsync(Guid id)
		{
			var product = DataConverter.ConvertProductEntityToProduct(await _productRepository.GetAsync(x => x.ProductId == id));

            return product;
        }
        public async Task<List<(string, string)>> GetProductColorsAndSizesAsync(string productName)
        {
            try
            {
                var combinations = new List<(string, string)>();

                var temp = await _productRepository.GetAllAsync(x => x.ProductName == productName);

                var products = await temp
                    .Include(c => c.Color)
                    .Include(s => s.Size)
					.Include(pi => pi.ProductInventory).ToListAsync();

                foreach (var product in products)
                {
                    combinations.Add((product.Size.Size, product.Color.Color));
                }
                return combinations;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null!;
        }


    }
}
