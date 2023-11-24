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
        private readonly IOrderService _orderService;
        private readonly IPromotionService _promotionService;


        public OrderController(ICookieService cookieService, ICustomerService customerService, IOrderService orderService, IPromotionService promotionService)
        {
            _cookieService = cookieService;
            _customerService = customerService;
            _orderService = orderService;
            _promotionService = promotionService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var productCookie = _cookieService.GetCookie(Request, "ProductsCookie");
                var cartList = JsonConvert.DeserializeObject<List<ProductCartObject>>(productCookie!);
                var order = new OrderSchema();

                if (cartList.Count == 0 || cartList is null)
                {
                    return RedirectToAction("Index", "Home");
                }


                order.Items = cartList;
                order = _orderService.CalculateTotalAmountOfNewOrder(order);


                var viewModel = new OrderViewModel
                {
                    Order = order,
                    SubTotal = order.TotalAmount,
                    OrderDataJson = JsonConvert.SerializeObject(order)
                };

                return View(viewModel);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return RedirectToAction("Index", "Home");
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

        [HttpPost]
        public async Task<IActionResult> ApplyPromocode(string promoCodeQuery, decimal discount, decimal currentTotal, List<PromotionCode> activePromotions)
        {

            var productCookie = _cookieService.GetCookie(Request, "ProductsCookie");
            var cartList = JsonConvert.DeserializeObject<List<ProductCartObject>>(productCookie!);
            var order = new OrderSchema();

            if (cartList.Count == 0 || cartList is null)
            {
                return RedirectToAction("Index", "Home");
            }

            order.Items = cartList;
            var totalBeforeDiscount = _orderService.CalculateTotalAmountOfNewOrder(order).TotalAmount;
            order.TotalAmount = currentTotal;

            var appliedPromotion = activePromotions.FirstOrDefault(x => x.Name == promoCodeQuery);

            if (appliedPromotion == null)
            {
                appliedPromotion = await _promotionService.GetPromotionCode(promoCodeQuery);
                if (appliedPromotion != null)
                {
                    activePromotions.Add(appliedPromotion);
                    discount = 0m;
                    foreach (var promotion in activePromotions)
                    {
                        discount += _promotionService.CalculatePromotionCodeDiscount(promotion.DiscountRate, totalBeforeDiscount);
                    }

                    order.TotalAmount = totalBeforeDiscount - discount;
                }
            }

            var viewModel = new OrderViewModel
            {
                Order = order,
                SubTotal = totalBeforeDiscount,
                ActivePromotions = activePromotions,
                Discount = discount,
                OrderDataJson = JsonConvert.SerializeObject(order)
            };

            return View("Index", viewModel);

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

        [HttpGet]
        public async Task<IActionResult> SubmitCheckout(string orderAsJsonObject)
        {
            var order = JsonConvert.DeserializeObject<OrderSchema>(orderAsJsonObject);

            var orderSucceeded = false;
            if (order is not null && ModelState.IsValid)
            {
                if (_orderService.VerifyOrder(order))
                {
                    orderSucceeded =  await _orderService.CreateOrder(order); 
                }
                return RedirectToAction("OrderConfirmationPage", orderSucceeded); 
            }
            return RedirectToAction("OrderConfirmationPage", orderSucceeded);
        }


        [HttpPost]
        public IActionResult Checkout(string orderDataJson, AddressSchema? addressSchema)
        {
            var order = JsonConvert.DeserializeObject<OrderSchema>(orderDataJson);

            var viewModel = new CheckoutViewModel();
            viewModel.Order = order;
            viewModel.DeliveryFee = "";      

            if(addressSchema.StreetAddress != null) 
            {
                viewModel.Order.DeliveryAddressSchema = addressSchema;
                viewModel.Order.BillingAddressSchema = addressSchema;
            }
            else
            {
                addressSchema = _orderService.CreateAddressSchema();
                viewModel.Order.DeliveryAddressSchema = addressSchema;
                viewModel.Order.BillingAddressSchema = addressSchema;
            }

            if(viewModel.Order.PaymentMethod == null)
                viewModel.Order.PaymentMethod = _orderService.CreatePaymentSchema();

            if(viewModel.Order.CustomerId <= 0)
                viewModel.Order.CustomerId = 1;

            viewModel.OrderDataJson = JsonConvert.SerializeObject(order);

            return View(viewModel);
        }
    }
}
