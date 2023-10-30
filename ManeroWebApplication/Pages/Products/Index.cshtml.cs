using DataAccess.Handlers.Services;
using DataAccess.Handlers.Services.Abstractions;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ManeroWebApplication.Pages.Products;

public class IndexModel : PageModel
{
	private readonly IProductService _productService;

	public IndexModel(IProductService productService)
    {
		_productService = productService;
	}


    public string ProductCategory { get; set; }


    public void OnGet(string productCategory) // sidan ska visa de produkter i den produktkategori som valts.
    {
        ProductCategory = productCategory;  


    }
}
