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


        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
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
        public IActionResult ShippingDetails(ShippingAddressSchema schema)
        {
            if (schema is not null && ModelState.IsValid)
            {
                return RedirectToAction("Index", schema);
            }
            return View();
        }

        public async Task<IActionResult> Checkout(int orderId) 
        {
            var viewModel = new CheckoutViewModel();
            //if(orderId > 0)
            //{
            //    var order = _orderService.GetOneOrderFromOrderIdAsync(orderId);

            //}


            viewModel.DeliveryFee = "";
            viewModel.TotalOrderSum = 0; //order.Result.TotalAmount;
            viewModel.OrderItems = await _orderService.GetOrderItemsFromOrderIdAsync(orderId);
            viewModel.OrderDiscount = 0; // _orderService.GetOrderDiscount(orderId);
            viewModel.ShippingDetails = "1006 Telefonvägen";
            viewModel.PaymentMethod = "Kort nr 348620"; //order.Result.PaymentMethod; 

            return View(viewModel);
        }
    }
}
