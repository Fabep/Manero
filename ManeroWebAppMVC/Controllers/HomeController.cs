using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ManeroWebAppMVC.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

     
    }
}