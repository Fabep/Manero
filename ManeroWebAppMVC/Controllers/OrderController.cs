using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ManeroWebAppMVC.Controllers
{
    public class OrderController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            var viewModel = new CheckoutViewModel();
            viewModel.TotalOrderSum = 0;
            //viewModel.Products = _service.GetOrderProducts();
            viewModel.OrderDiscount = 0;
            viewModel.DeliveryFee = "Free";
            viewModel.ShippingDetails = "1006 Telefonvägen";
            viewModel.PaymentMethod = "Kort nr 348620";

            return View(viewModel);
        }
    }
}
