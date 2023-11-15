using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models.Schemas;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ManeroWebAppMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICustomerService _customerService;
        public OrderController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index(ShippingAddressSchema shippingAddress = null!)
        {
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
                return RedirectToAction("Index", new { shippingAddress = schema });
            return View();
        }
    }
}
