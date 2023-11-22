using DataAccess.Handlers.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManeroWebApplication.Pages.Products
{
    public class SalesProductsModel : PageModel
    {
        private readonly ProductRepository _productRepository;
        public SalesProductsModel(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public List<DataAccess.Models.Product> FeaturedProducts { get; set; }

		public async Task OnGet()
		{
			var featuredProductList = _productRepository.GetAll(x => x.ProductPrice < 500);

			FeaturedProducts = featuredProductList
				.Select(p => new DataAccess.Models.Product
				{
					ProductName = p.ProductName,
					ProductDescription = p.ProductDescription,
					ProductPrice = p.ProductPrice * 0.5m, // Dra av 50 % från priset
					Rating = p.Rating ?? 0,
					Quantity = p.Quantity ?? 0
				})
				.ToList();
		}

	}

}
