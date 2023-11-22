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
using DataAccess.ExtensionMethods;
using System.Diagnostics;

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

        [HttpGet]
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



                var viewModel = new OrderViewModel
                {
                    Order = order,
                };


                return View(viewModel);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
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



        public async Task<IActionResult> SubmitCheckout(OrderSchema order)
        {
            if (order is not null && ModelState.IsValid)
            {
                //verifiera order i service
                if (order.PaymentMethod != null && order.TotalAmount > 0
                    && order.BillingAddressSchema != null && order.DeliveryAddressSchema != null
                    && order.Items?.Count > 0)
                {

                    // orderSchema till orderEntity gör om i en orderservice 
                    var orderEntity = DataConverter.ConvertOrderSchemaToOrderEntity(order);
                    foreach (var item in order.Items)
                    {
                        // orderitems är productCartObjet och ska sparas i databas som orderitem
                        var orderItemEntity = new OrderItemsEntity();
                        orderItemEntity.ProductId = item.ProductId;


                        /*
                        orderitem
                            public int OrderItermsId { get; set; } - skapas automatiskt?
                            public int OrderId { get; set; } - från ordern
		                    public OrdersEntity? Order { get; set; }
		                    public int ProductId { get; set; } -  productid från productcartobject
		                    public string? ProductName { get; set; } - från productcartobject
		                    public decimal TotalAmount { get; set; } - quantity * price från productcartobject
                            public decimal DiscountPrice { get; set; } - quantity * discount price från productcartobject
		                    public int Quantity { get; set; } - quantity från productcartobject

                         productcartobjet
                            public Guid ProductId { get; set; }
                            public string ProductName { get; set; } = null!;
                            public double Price { get; set; }
                            public double DiscountedPrice { get; set; }
                            public string Size { get; set; } = null!;
                            public string Color { get; set; } = null!;
                            public int Quantity { get; set; }
                            public string ImageUrl { get; set; } = null!;

                 
                        */



                    }

                    // spara  i databas

                    return RedirectToAction("");// gå till sida för att se om ordern lyckats
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Checkout(OrderSchema schema)
        {
            var viewModel = new CheckoutViewModel();
            viewModel.Order = schema;
            viewModel.DeliveryFee = "";
            return View(viewModel);
        }
    }
}
