using DataAccess.Models.Entities;
using DataAccess.Models;
using DataAccess.Enums;
using DataAccess.Models.ViewModels;

namespace DataAccess.Handlers.Services.Abstractions
{
    public interface IProductService
    {

        Task<List<Product>> GetBestSellersAsync();
        Task<List<Product>> GetFeaturedProductsAsync();
        public List<Product> GetSortedListOfProducts(
          string sortOrder, List<Product> productList);
        bool ShouldHavePromotion(ProductEntity product);
        Promotion GetPromotion();
        public Task<List<Product>> GetAllBestSellersAsProductsAsync();
        public Task<List<Product>> GetProductsFromSubCategoryAsync(string subProductCategory);
        public Task<List<SizeColorCombination>> GetProductColorsAndSizesAsync(string productName);
        public Task<Product> GetOneProductFromNameAsync(string productName);
        public Task<Product> GetOneProductFromIdAsync(Guid id);
        void SetSizesAndColors(ArticleViewModel viewModel, SizeEnum? selectedSize, string selectedColor);
        Task<Product> FindProduct(string productName, string selectedSize, string selectedColor);
        public Task<List<Product>> SearchProductsAsync(string query);
        public  Task<List<Product>> GetFilteredProducts(string color, double? minPrice, double? maxPrice, string subCategory);





    }
}
