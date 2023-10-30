using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManeroWebApplication.Pages.Products
{
    public class BestSellersModel : PageModel
	{

		private readonly ProductRepository _productRepository;

		public BestSellersModel(ProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		public List<DataAccess.Models.Product> BestSellers { get; set; }

		public async Task OnGet()
		{

			var productList = await _productRepository.GetAllAsync(x => x.ProductPrice < 900);

			BestSellers = productList
			 .Select(p => DataConverter.ConvertProductEntityToProduct(p))
			 .ToList();

		}
	}
}
