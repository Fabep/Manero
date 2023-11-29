using DataAccess.Handlers.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManeroWebApplication.Pages.Products
{
    public class FeaturedProductsModel : PageModel
    {
		private readonly ProductRepository _productRepository;

		public FeaturedProductsModel(ProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		
		public List<DataAccess.Models.Product> FeaturedProducts { get; set; }

		public async Task OnGet()
		{
			



			var featuredProductList = _productRepository.GetAll(x => x.ProductPrice < 1000);

			FeaturedProducts = featuredProductList
				.Select(p => new DataAccess.Models.Product
				{
					ProductName = p.ProductName,
					ProductDescription = p.ProductDescription,
					ProductPrice = p.ProductPrice,
					Rating = p.Rating ?? 0,
					Quantity = p.Quantity ?? 0
				})
				.ToList();
		}
	}
}
