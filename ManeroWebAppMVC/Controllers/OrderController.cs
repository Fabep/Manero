using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ManeroWebAppMVC.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new OrderViewModel();
            return View(viewModel);
        }
    }
}
