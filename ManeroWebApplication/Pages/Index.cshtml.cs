using DataAccess.Contexts;
using DataAccess.Models;
using DataAccess.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace ManeroWebApplication.Pages
{
    public class IndexModel : PageModel
    {
		private readonly ILogger<IndexModel> _logger;
		private readonly LocalContext _context; // Använd din faktiska kontextklass

		public IndexModel(ILogger<IndexModel> logger, LocalContext context)
		{
			_logger = logger;
			_context = context;
		}

		public List<Product> Products { get; set; }

		public async Task OnGet()
		{
			Expression<Func<ProductEntity, bool>> expression = p => p.ProductPrice < 1000;

			Products = await _context.Products
				.Where(expression)
				.Select(p => new Product
				{
					ProductName = p.ProductName,
					ProductDescription = p.ProductDescription,
					ProductPrice = p.ProductPrice,
					Rating = p.Rating ?? 0,
					Quantity = p.Quantity ?? 0
				})
				.ToListAsync();
		}
	}
}