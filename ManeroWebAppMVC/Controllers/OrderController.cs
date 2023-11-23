﻿using DataAccess.Handlers.Services.Abstractions;
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
        public IActionResult ApplyPromocode(string promocode)
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
                OrderDataJson = JsonConvert.SerializeObject(order)
            };


            return View(viewModel);

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
        public async Task<IActionResult> SubmitCheckout(OrderSchema order)
        {
            var orderSucceeded = false;
            if (order is not null && ModelState.IsValid)
            {
                if (_orderService.VerifyOrder(order))
                {
                    orderSucceeded =  await _orderService.CreateOrder(order); 
                }
                return RedirectToAction("alex sida", orderSucceeded); 
            }
            return RedirectToAction("alex sida", orderSucceeded);
        }


        [HttpGet]
        public async Task<IActionResult> Checkout(string orderDataJson)
        {

            var order = JsonConvert.DeserializeObject<OrderSchema>(orderDataJson);

            var viewModel = new CheckoutViewModel();
            viewModel.Order = order;
            viewModel.DeliveryFee = "";
            return View(viewModel);
        }
    }
}
