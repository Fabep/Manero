using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.ViewModels;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models.Schemas;
using DataAccess.Models.ViewModels;
using DataAccess.Handlers.Services;
using DataAccess.Models;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DataAccess.Models.Entities;

namespace ManeroWebAppMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICookieService _cookieService;
        private readonly ICustomerService _customerService;
        private readonly IOrderService _orderService;

        public OrderController(ICookieService cookieService, ICustomerService customerService, IOrderService orderService)
        {
            _cookieService = cookieService;
            _customerService = customerService;
            _orderService = orderService;
        }

        public IActionResult Index()
        {

            try
            {
                var productCookie = _cookieService.GetCookie(Request, "ProductsCookie");
                var cartList = JsonConvert.DeserializeObject<List<ProductCartObject>>(productCookie!);


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



        //     [HttpPost]
        public async Task<IActionResult> SubmitCheckout(CheckoutViewModel viewModel)
        {

            if (viewModel is not null && ModelState.IsValid)
            {

                //verifiera order i service
                if (viewModel.PaymentMethod != null && viewModel.TotalOrderSum > 0
                    && viewModel.ShippingDetails != null && viewModel.OrderItems?.Count > 0)
                {

                    // spara  i databas

                    // orderSchema till orderservice där det blir en orderentity

                    return RedirectToAction("");// gå till sida för att se om ordern lyckats
                }

            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Checkout(object products, ShippingAddressSchema? schema)
        {
            var order = new OrdersEntity();

            // gör en produktlista - orderitems 




            var viewModel = new CheckoutViewModel();

            viewModel.DeliveryFee = "";
            viewModel.TotalOrderSum = 0; //order.Result.TotalAmount;
            // viewModel.OrderItems = ; // await _orderService.GetOrderItemsFromOrderIdAsync(orderId);
            viewModel.OrderDiscount = 0; // _orderService.GetOrderDiscount(orderId);

            // ShippingDetails sparas
            viewModel.ShippingDetails = schema;

            viewModel.PaymentMethod = "Kort nr 348620"; //order.Result.PaymentMethod; 

            return View(viewModel);

        }
    }
}
