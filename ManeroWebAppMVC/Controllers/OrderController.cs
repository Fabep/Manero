using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services;
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
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ShippingDetails(int cid)
        {
            var vm = new ShippingDetailsViewModel();

            foreach(var customerAddress in await _customerService.GetAllCustomerAddressesFromCustomerId(cid))
            {
                vm.CustomerAddresses.Add(customerAddress);
            }
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> ShippingDetailsSubmit(CustomerAddressSchema schema)
        {
            return null!;
        }
    }
}
