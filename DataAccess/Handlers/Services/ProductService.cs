using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Handlers.Services
{
    public class ProductService : IProductService
	{
		private readonly ProductRepository _productRepository;
        public List<Product> BestSellers { get; set; }
		public List<Product> ProductsFromSubCategory { get; set; }



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
    
        public async Task GetAllBestSellersAsProductsAsync()
        {
            var productList = await _productRepository.GetAllAsync(x => x.ProductPrice > 900);

            BestSellers = productList
             .Select(p => DataConverter.ConvertProductEntityToProduct(p))
             .ToList();
        }

        public async Task<List<Product>> GetProductsFromSubCategoryAsync(string subProductCategory)
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

		public async Task<Product> GetOneProductFromIdAsync(Guid id)
		{
			var product = DataConverter.ConvertProductEntityToProduct(await _productRepository.GetAsync(x => x.ProductId == id));

            return product;
        }

    }


}
