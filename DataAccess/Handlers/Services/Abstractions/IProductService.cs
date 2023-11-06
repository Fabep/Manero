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
        bool ShouldHavePromotion(ProductEntity product);
        Promotion GetPromotion();
        public Task<List<Product>> GetAllBestSellersAsProductsAsync();
        public Task<List<Product>> GetProductsFromSubCategoryAsync(string subProductCategory);
        public Task<List<SizeColorCombination>> GetProductColorsAndSizesAsync(string productName);
        public Task<Product> GetOneProductFromNameAsync(string productName);
        public Task<Product> GetOneProductFromIdAsync(Guid id);
        void SetSizesAndColors(ArticleViewModel viewModel, SizeEnum? selectedSize, string selectedColor);
    }
}
