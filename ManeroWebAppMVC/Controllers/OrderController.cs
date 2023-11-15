using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ManeroWebAppMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly CustomerAddressRepository _customerAddressRepository;
        public OrderController(CustomerAddressRepository customerAddressRepository)
        {
            _customerAddressRepository = customerAddressRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ShippingDetails(int cid)
        {
            var vm = new ShippingDetailsViewModel();

            foreach(var details in _customerAddressRepository.GetAll(x => x.CustomerId == cid))
            {
                vm.CustomerAddresses.Add(DataConverter.ConvertCustomerAddressEntityToCustomerAddress(details));
            }
            return View(vm);
        }
    }
}
