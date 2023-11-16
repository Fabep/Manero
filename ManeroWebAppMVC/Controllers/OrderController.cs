using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ManeroWebAppMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICookieService _cookieService;

        public OrderController(ICookieService cookieService)
        {
            _cookieService = cookieService;
        }

        public IActionResult Index()
        {

            try
            {
                var productCookie = _cookieService.GetCookie(Request, "ProductsCookie");
                var cartList = JsonConvert.DeserializeObject<List<ProductCartObject>>(productCookie!);


                var order = new OrderObject();
                order.Items = cartList;


                foreach (var item in order.Items!)
                {
                    if (item.DiscountedPrice > 0)
                        order.TotalAmount += item.DiscountedPrice * item.Quantity;
                    else
                        order.TotalAmount += item.Price * item.Quantity;
                }

                var viewModel = new OrderViewModel
                { 
                    Order = order,
                };


                return View(viewModel);

            }
            catch (Exception)
            {

            }

            return View();
        }
    }
}
