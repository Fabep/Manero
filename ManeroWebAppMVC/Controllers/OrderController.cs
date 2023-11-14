using Microsoft.AspNetCore.Mvc;

namespace ManeroWebAppMVC.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ShippingDetails()
        {


            return View();
        }
    }
}
