using DataAccess.Models.Entities;
using DataAccess.Models;
using DataAccess.Enums;

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
        public Task<List<(SizeEnum, string)>> GetProductColorsAndSizesAsync(string productName);
        public Task<Product> GetOneProductFromNameAsync(string productName);
        public Task<Product> GetOneProductFromIdAsync(Guid id);
    }
}
