 using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models.Schemas;
using ManeroWebAppMVC.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ManeroWebAppMVC.Tests.Controllers
{
    public class OrderControllerTests
    {
        private readonly OrderController _controller;
        private readonly Mock<ICookieService> _mockCookieService;
        private readonly Mock<ICustomerService> _mockCustomerService;
        private readonly Mock<IOrderService> _mockOrderService;
        private readonly Mock<IPromotionService> _mockPromotionService;

        public OrderControllerTests()
        {
            _mockCookieService = new Mock<ICookieService>();
            _mockCustomerService = new Mock<ICustomerService>();
            _mockOrderService = new Mock<IOrderService>();
            _mockPromotionService = new Mock<IPromotionService>();

            _controller = new OrderController(
                _mockCookieService.Object,
                _mockCustomerService.Object,
                _mockOrderService.Object,
                _mockPromotionService.Object
            );
        }

        [Fact]
        public async Task SubmitCheckout_RedirectsToOrderConfirmationPage_OnSuccess()
        {
            // Arrange
            var orderSchemaJson = "{\"CustomerId\":123,\"Items\":[{\"ProductName\":\"T-shirt\",\"Size\":\"M\",\"Color\":\"blue\",\"Quantity\":2,\"Price\":19.99},{\"ProductName\":\"Jeans\",\"Size\":\"32\",\"Color\":\"black\",\"Quantity\":1,\"Price\":49.99}],\"TotalAmount\":89.97,\"PromotionDiscount\":10.00,\"BillingAddressSchema\":{\"City\":\"Stockholm\",\"StreetAddress\":\"Vägen 123\",\"Streetnumber\":\"10A\",\"Country\":\"Sverige\",\"PostalCode\":\"12345\",\"Region\":\"Stockholms län\"},\"DeliveryAddressSchema\":{\"City\":\"Stockholm\",\"StreetAddress\":\"Vägen 123\",\"Streetnumber\":\"10A\",\"Country\":\"Sverige\",\"PostalCode\":\"12345\",\"Region\":\"Stockholms län\"},\"PaymentMethod\":{\"CardNumber\":\"1234567890\",\"ExpiryDate\":\"12/23\",\"Cvv\":\"123\"}}";
            _mockOrderService.Setup(s => s.VerifyOrder(It.IsAny<OrderSchema>())).Returns(true);
            _mockOrderService.Setup(s => s.CreateOrder(It.IsAny<OrderSchema>())).ReturnsAsync(true);

            // Act
            var result = await _controller.SubmitCheckout(orderSchemaJson) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("OrderConfirmationPage", result.ActionName);
            Assert.True((bool)result.RouteValues["orderSucceeded"]); //Bool = true => Order Successfull
        }

        [Fact]
        public async Task SubmitCheckout_RedirectsToOrderConfirmationPage_OnFailure()
        {
            // Arrange
            var orderSchemaJson = "{\"CustomerId\":123,\"Items\":[{\"ProductName\":\"T-shirt\",\"Size\":\"M\",\"Color\":\"blue\",\"Quantity\":2,\"Price\":19.99}],\"TotalAmount\":39.98,\"PromotionDiscount\":0,\"BillingAddressSchema\":{\"City\":\"Stockholm\",\"StreetAddress\":\"Vägen 123\",\"Streetnumber\":\"10A\",\"Country\":\"Sverige\",\"PostalCode\":\"12345\",\"Region\":\"Stockholms län\"},\"DeliveryAddressSchema\":{\"City\":\"Stockholm\",\"StreetAddress\":\"Vägen 123\",\"Streetnumber\":\"10A\",\"Country\":\"Sverige\",\"PostalCode\":\"12345\",\"Region\":\"Stockholms län\"},\"PaymentMethod\":{\"CardNumber\":\"1234567890\",\"ExpiryDate\":\"12/23\",\"Cvv\":\"123\"}}";
            _mockOrderService.Setup(s => s.VerifyOrder(It.IsAny<OrderSchema>())).Returns(false); // Simulera ett misslyckande i ordervalideringen

            // Act
            var result = await _controller.SubmitCheckout(orderSchemaJson) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("OrderConfirmationPage", result.ActionName);
            Assert.False((bool)result.RouteValues["orderSucceeded"]);//Bool = False => Order Failed
        }
    }
}
