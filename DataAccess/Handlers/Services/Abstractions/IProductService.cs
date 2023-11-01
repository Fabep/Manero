using DataAccess.Models;

namespace DataAccess.Handlers.Services.Abstractions
{
    public interface IProductService
    {

        public Task GetAllBestSellersAsProducts();
        public Task<List<Product>> GetProductsFromSubCategory(string subProductCategory);
        public Task<Dictionary<string, string>> GetProductColorsAndSizesAsync(string productName);
        public Task<Product> GetOneProductFromNameAsync(string productName);
    }
}
