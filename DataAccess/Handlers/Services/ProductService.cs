using DataAccess.Enums;
using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.Entities;
using DataAccess.Models.ViewModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

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
            var products = CalculateDiscount(productList);

            return products;
        }

		public async Task<List<Product>> GetFeaturedProductsAsync()
		{
			var featuredProductList = await _productRepository.GetAllAsync(x => x.IsFeaturedProduct == true); 
            var products = CalculateDiscount(featuredProductList);

            return products;
        }

        public List<Product> GetSortedListOfProducts(string sortOrder, List<Product> productList)
        {
            if (sortOrder == null) 
                return productList;

            switch (sortOrder)
            {
                case "ProductNameAsc":
                    productList = productList.OrderBy(p => p.ProductName).ToList();
                    break;
                case "ProductNameDesc":
                    productList = productList.OrderByDescending(p => p.ProductName).ToList();
                    break;
                case "ProductPriceAsc":
                    productList = productList.OrderBy(p => p.ProductPrice).ToList();
                    break;
                case "ProductPriceDesc":
                    productList = productList.OrderByDescending(p => p.ProductPrice).ToList();
                    break;
                case "DiscountedPriceAsc":
                    productList = productList.OrderBy(p => p.DiscountedPrice).ToList();
                    break;
                case "DiscountedPriceDesc":
                    productList = productList.OrderByDescending(p => p.DiscountedPrice).ToList();
                    break;
                case "RatingAsc":
                    productList = productList.OrderBy(p => p.Rating).ToList();
                    break;
                case "RatingDesc":
                    productList = productList.OrderByDescending(p => p.Rating).ToList();
                    break;

                default:
                    break;
            }

            return productList;
        }

        public List<Product> CalculateDiscount(IQueryable<ProductEntity> productEntities)
        {
            var products = new List<Product>();
            foreach (var productEntity in productEntities)
            {
                var product = DataConverter.ConvertProductEntityToProduct(productEntity);

                if (ShouldHavePromotion(productEntity))
                {
                    product.Promotion = GetPromotion();
                    var discount = product.ProductPrice * product.Promotion.DiscountRate;
                    product.DiscountedPrice = product.ProductPrice - discount;
                }

                products.Add(product);
            }

            return products;
        }

        public bool ShouldHavePromotion(ProductEntity product)
        {
            return product.ProductPrice < 499;
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

        public async Task<List<SizeColorCombination>> GetProductColorsAndSizesAsync(string productName)
        {
            try
            {
                var combinations = new List<SizeColorCombination>();

                var temp = await _productRepository.GetAllAsync(x => x.ProductName == productName);

                var products = await temp
                    .Include(c => c.Color)
                    .Include(s => s.Size)
					.Include(pi => pi.ProductInventory).ToListAsync();
				var size = SizeEnum.S;
                foreach (var product in products)
                {
					Enum.TryParse<SizeEnum>(product.Size!.Size, out size);
                    combinations.Add(new SizeColorCombination
					{
						Size = new Size { SizeType = size },
						Color = new Color { ColorName = product.Color!.Color }
					});
                }
                return combinations;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null!;
        }

        public void SetSizesAndColors(ArticleViewModel viewModel, SizeEnum? selectedSize, string selectedColor)
        {
			try
			{
				if (selectedColor is not null)
				{
					viewModel.Sizes = viewModel.Combinations.Where(s => s.Color.ColorName == selectedColor).Select(x => x.Size).DistinctBy(s => s.SizeType).OrderBy(x => x.SizeType).ToList();
					viewModel.Colors = viewModel.Combinations.Select(x => x.Color).DistinctBy(c => c.ColorName).ToList();
				}
				else if (selectedSize is not null)
				{
					viewModel.Sizes = viewModel.Combinations.Select(x => x.Size).DistinctBy(s => s.SizeType).OrderBy(x => x.SizeType).ToList();
					viewModel.Colors = viewModel.Combinations.Where(c => c.Size.SizeType == selectedSize).Select(x => x.Color).DistinctBy(c => c.ColorName).ToList();
				}
				else
				{
					viewModel.Sizes = viewModel.Combinations.Select(x => x.Size).DistinctBy(s => s.SizeType).OrderBy(x => x.SizeType).ToList();
					viewModel.Colors = viewModel.Combinations.Select(x => x.Color).DistinctBy(c => c.ColorName).ToList();
				}
            }
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
        }

        public async Task<Product> FindProduct(string productName, string selectedSize, string selectedColor)
        {
			return DataConverter.ConvertProductEntityToProduct(await _productRepository.GetAsync(x => x.ProductName == productName && x.Color.Color == selectedColor && x.Size.Size == selectedSize));
        }

        public async Task<List<Product>> SearchProductsAsync(string query)
        {
            try
            {
                var productList = await _productRepository.GetAllAsync(x => x.ProductName.Contains(query));

                var products = productList.Select(p => DataConverter.ConvertProductEntityToProduct(p)).ToList();

                return products;
            }
            catch (Exception ex)
            {
               
                Debug.WriteLine($"Ett fel uppstod vid sökning: {ex.Message}");

                
                return new List<Product>();
            }
        }
        public async Task<List<Product>> GetFilteredProducts(string color, double? minPrice, double? maxPrice,string subCategory)
        {
            try
            {
                // Skapa en Expression<Func<ProductEntity, bool>> baserat på dina filtreringskriterier
                Expression<Func<ProductEntity, bool>> filterExpression = x =>
                    (string.IsNullOrEmpty(color) || x.Color.Color.Contains(color)) &&
                    (string.IsNullOrEmpty(subCategory) || x.SubCategory.SubCategoryName.Contains(subCategory)) &&
                    (!minPrice.HasValue || x.ProductPrice >= minPrice.Value) &&
                    (!maxPrice.HasValue || x.ProductPrice <= maxPrice.Value);

                // Hämta produktlistan från databasen baserat på filteruttrycket
                var productList = await _productRepository.GetAllAsync(filterExpression);

                // Konvertera och returnera produkterna
                var products = productList.Select(p => DataConverter.ConvertProductEntityToProduct(p)).ToList();
                return products;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ett fel uppstod vid sökning: {ex.Message}");
                return new List<Product>();
            }
        }




    }
}