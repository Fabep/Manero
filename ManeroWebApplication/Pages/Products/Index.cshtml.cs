using DataAccess.Handlers.Services;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManeroWebApplication.Pages.Products;

public class IndexModel : PageModel
{
	private readonly IProductService _productService;

	public IndexModel(IProductService productService)
    {
		_productService = productService;
	}


    public string PageTitle { get; set; }
    public List<Product> ProductList { get; set; }


    public async Task OnGet(string subProductCategory) // sidan ska visa de produkter i den produktkategori som valts.
    {
		PageTitle = subProductCategory;
        ProductList = await _productService.GetProductsFromSubCategory(subProductCategory);
    }
}
