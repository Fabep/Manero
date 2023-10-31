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
			var productList = await _productRepository.GetAllAsync(x => x.ProductPrice < 900);

			BestSellers = productList
			 .Select(p => DataConverter.ConvertProductEntityToProduct(p))
			 .ToList();
		}

		public async Task<List<Product>> GetProductsFromSubCategory(string subProductCategory)
		{
			//var productList = _subCategoryRepository....

			// vill hämta de produkter som tillhör vald subkategori
			var productList = await _productRepository.GetAllAsync(x => x.GetType() == typeof(ProductEntity));
			

			ProductsFromSubCategory = productList.AsQueryable().Include(a => a.SubCategoryEntity()).ToList();

			//ProductsFromSubCategory = productList
			//	.Select(productList => DataConverter.ConvertProductEntityToProduct(p))
			//	.ToList();

			return ProductsFromSubCategory;
		}


	}
}
