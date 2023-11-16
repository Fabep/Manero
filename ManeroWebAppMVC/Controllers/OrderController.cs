using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.ViewModels;
using DataAccess.Models.Schemas;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

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
        public async Task<IActionResult> Address(string addressType, OrderSchema orderSchema)
        {
            var vm = new OrderAddressViewModel
            {
                Order = orderSchema,
                AddressType = addressType,
            };
            if (orderSchema.CustomerId > 0)
                vm.CustomerAddresses.AddRange(await _customerService.GetAllCustomerAddressesFromCustomerId(orderSchema.CustomerId));
            return View(vm);
        }
        [HttpPost]
        public IActionResult Address(OrderSchema orderSchema, ShippingAddressSchema addressSchema, string addressType)
        {
            try
            {
                if (addressType == "Billing")
                    orderSchema.BillingAddressSchema = addressSchema;
                else if (addressType == "Delivery")
                    orderSchema.DeliveryAddressSchema = addressSchema;
                else
                {
                    throw new Exception("Unspecified address type.");
                }
                return RedirectToAction("Checkout", orderSchema);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return RedirectToAction("Checkout", orderSchema);
        }
    }
}
