using DataAccess.Models.Entities;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Services.Abstractions
{
	public interface IProductService
	{
		Task<List<Product>> GetBestSellersAsync();
		Task<List<Product>> GetFeaturedProductsAsync();
		bool ShouldHavePromotion(ProductEntity product);
		Promotion GetPromotion();
        public Task GetAllBestSellersAsProducts();
        public Task<List<Product>> GetProductsFromSubCategory(string subProductCategory);
    }
}
