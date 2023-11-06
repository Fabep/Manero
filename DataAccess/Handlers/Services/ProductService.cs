using DataAccess.Enums;
using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

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
			var featuredProductList = await _productRepository.GetAllAsync(x => x.IsFeaturedProduct == true);
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

        public List<Product> GetSortedListOfProducts(string sortOrder, string sortParameter, List<Product> productList)
        {
            if (sortParameter == null || sortOrder == null)
                return productList;

            switch (sortParameter)
            {
                case "ProductName":
                    productList = sortOrder == "asc" ? productList.OrderBy(p => p.ProductName).ToList() 
                        : productList.OrderByDescending(p => p.ProductName).ToList();
                    break;
                case "ProductPrice":
                    productList = sortOrder == "asc" ? productList.OrderBy(p => p.ProductPrice).ToList() 
                        : productList.OrderByDescending(p => p.ProductPrice).ToList();
                    break;
                case "DiscountedPrice":
                    productList = sortOrder == "asc" ? productList.OrderBy(p => p.DiscountedPrice).ToList() 
                        : productList.OrderByDescending(p => p.DiscountedPrice).ToList();
                    break;
                default:
                    break;
            }

            return productList;
        }

        public bool ShouldHavePromotion(ProductEntity product)
        {
            return product.ProductPrice < 799;
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
            var productList = await _productRepository.GetAllAsync(x => x.IsBestSeller == true);

            return productList
             .Select(p => DataConverter.ConvertProductEntityToProduct(p))
             .ToList();
        }

        public async Task<List<Product>> GetProductsFromSubCategoryAsync(string subProductCategory)
        {
            // vill hämta de produkter som tillhör vald subkategori
            var productList = await _productRepository.GetAllAsync(x => x.GetType() == typeof(ProductEntity));

            var productsFromSubCategory = await productList.Include(x => x.SubCategory)
                .Where(s => s.SubCategory.SubCategoryName == subProductCategory)
                .Select(p => DataConverter.ConvertProductEntityToProduct(p))
                .ToListAsync();

            //ProductsFromSubCategory = productList
            //	.Select(productList => DataConverter.ConvertProductEntityToProduct(p))
            //	.ToList();

            return productsFromSubCategory;
        }
        public async Task<Product> GetOneProductFromNameAsync(string productName)
        {
            var productEntity = await _productRepository.GetAsync(x => x.ProductName == productName);
            var product = DataConverter.ConvertProductEntityToProduct(productEntity);

            // Apply the promotion logic
            if (ShouldHavePromotion(productEntity))
            {
                var promotion = GetPromotion();
                product.Promotion = promotion;

                // Calculate the discounted price
                product.DiscountedPrice = product.ProductPrice * (1 - promotion.DiscountRate);
            }

            return product;
        }


        public async Task<Product> GetOneProductFromIdAsync(Guid id)
        {
            var productEntity = await _productRepository.GetAsync(x => x.ProductId == id);
            var product = DataConverter.ConvertProductEntityToProduct(productEntity);

            if (ShouldHavePromotion(productEntity))
            {
                var promotion = GetPromotion();
                product.Promotion = promotion;

                // Calculate the discounted price
                product.DiscountedPrice = product.ProductPrice * (1 - promotion.DiscountRate);
            }

            return product;
        }

        public async Task<List<(SizeEnum, string)>> GetProductColorsAndSizesAsync(string productName)
        {
            try
            {
                var combinations = new List<(SizeEnum, string)>();

                var temp = await _productRepository.GetAllAsync(x => x.ProductName == productName);

                var products = await temp
                    .Include(c => c.Color)
                    .Include(s => s.Size)
					.Include(pi => pi.ProductInventory).ToListAsync();
				var size = SizeEnum.S;
                foreach (var product in products)
                {
					Enum.TryParse<SizeEnum>(product.Size.Size, out size);
                    combinations.Add((size, product.Color.Color));
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