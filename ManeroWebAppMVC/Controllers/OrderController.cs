using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.ViewModels;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models.Schemas;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ManeroWebAppMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICookieService _cookieService;
        private readonly ICustomerService _customerService;

        public OrderController(ICookieService cookieService, ICustomerService customerService)
        {
            _cookieService = cookieService;
            _customerService = customerService;
        }

        public IActionResult Index()
        {

            try
            {
                var productCookie = _cookieService.GetCookie(Request, "ProductsCookie");
                var cartList = JsonConvert.DeserializeObject<List<ProductCartObject>>(productCookie!);

                if (cartList.Count == 0 || cartList is null)
                {
                    return RedirectToAction("Index", "Home");
                }


                var order = new OrderSchema();
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

        [HttpPost]
        public IActionResult ChangeQuantity(Guid productId, string operation)
        {
            var cartList = JsonConvert.DeserializeObject<List<ProductCartObject>>(_cookieService.GetCookie(Request, "ProductsCookie")!);

            if (cartList!.Select(x => x.ProductId).Contains(productId))
            {

                if (operation == "increase")
                {
                    cartList!.FirstOrDefault(x => x.ProductId == productId)!.Quantity += 1;
                }
                else if (operation == "decrease" && cartList!.FirstOrDefault(x => x.ProductId == productId)!.Quantity > 1)
                {
                    cartList!.FirstOrDefault(x => x.ProductId == productId)!.Quantity += -1;
                }

                _cookieService.AddCookie(Response, "ProductsCookie", cartList);
            }

            return RedirectToAction("Index");

        }





        [HttpGet]
        public async Task<IActionResult> ShippingDetails(int? cid)
        {
            var vm = new ShippingDetailsViewModel();
            if (cid is not null)
            {
                foreach (var customerAddress in await _customerService.GetAllCustomerAddressesFromCustomerId((int)cid!))
                {
                    vm.CustomerAddresses.Add(customerAddress);
                }
            }
            return View(vm);
        }
        [HttpPost]
        public IActionResult ShippingDetails(AddressSchema schema)
        {
            if (schema is not null && ModelState.IsValid)
            {
                return RedirectToAction("Checkout", schema);
            }
            return View();
        }
    }
}
