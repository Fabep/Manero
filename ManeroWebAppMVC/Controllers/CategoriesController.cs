using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ManeroWebAppMVC.Controllers
{
	public class CategoriesController : Controller
	{
		private readonly ICategoryService _categoryService;

		public CategoriesController(ICategoryService _categoryService)
		{
			this._categoryService = _categoryService;
		}
		public async Task<IActionResult> Index()
		{
			var viewModel = new CategoriesViewModel()
			{
				PrimaryCategories = await _categoryService.GetAllPrimaryCategories()
			};


			return View(viewModel);
		}
	}
}
