using Microsoft.AspNetCore.Mvc;

namespace ManeroWebAppMVC.Controllers
{
	public class CategoriesController : Controller
	{
		public CategoriesController()
		{

		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
