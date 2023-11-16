using DataAccess.Handlers.Services;
using DataAccess.Models;
using DataAccess.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ManeroWebAppMVC.Controllers
{
    public class OrderController : Controller
    {

        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }


        public IActionResult Index()
        {
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
