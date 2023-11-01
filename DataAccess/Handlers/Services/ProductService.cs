using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Services
{
	public class ProductService :IProductService
    {
		private readonly ProductRepository _productRepository;
		private readonly SubCategoryRepository _subCategoryRepository;

		public ProductService(ProductRepository productRepository)
		{
			_productRepository = productRepository;
		}


		public List<Product> BestSellers { get; set; }
		public List<Product> ProductsFromSubCategory { get; set; }



		public async Task GetAllBestSellersAsProducts()
		{
			var productList = await _productRepository.GetAllAsync(x => x.ProductPrice > 900);

			BestSellers = productList
			 .Select(p => DataConverter.ConvertProductEntityToProduct(p))
			 .ToList();
		}

		public async Task<List<Product>> GetProductsFromSubCategory(string subProductCategory)
		{
			// vill hämta de produkter som tillhör vald subkategori
			var productList = await _productRepository.GetAllAsync(x => x.GetType() == typeof(ProductEntity));

			 ProductsFromSubCategory = productList.AsQueryable().Include(a => a.SubCategory)
				.Select(p => DataConverter.ConvertProductEntityToProduct(p))
				.ToList();

			//ProductsFromSubCategory = productList
			//	.Select(productList => DataConverter.ConvertProductEntityToProduct(p))
			//	.ToList();

			return ProductsFromSubCategory;
		}
        public async Task<Product> GetOneProductFromNameAsync(string productName)
        {
            return DataConverter.ConvertProductEntityToProduct(await _productRepository.GetAsync(x => x.ProductName == productName));
        }

        public async Task<Dictionary<string, string>> GetProductColorsAndSizesAsync(string productName)
        {
            try
            {
                var combinations = new Dictionary<string, string>();

                var temp = await _productRepository.GetAllAsync(x => x.ProductName == productName);
                var products = temp.AsQueryable()
                    .Include(c => c.ColorEntity)
                    .Include(s => s.SizeEntity).ToList();

                foreach (var product in products)
                {
                    combinations.Add(product.Size.SizeName, product.Color.ColorName);
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
