using DataAccess.Contexts;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Handlers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models.Schemas;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Tests.Handlers.Services
{
    public class OrderServiceTests
    {
        private IOrderService _sut;
        private OrderRepository _orderRepository;
        private OrderItemRepository _orderItemRepository;
        private LocalContext _localContext;

        public OrderServiceTests()
        {
            _localContext = LocalContext();
            _orderRepository = new OrderRepository(_localContext);
            _orderItemRepository = new OrderItemRepository(_localContext);
            _sut = new OrderService(_orderRepository, _orderItemRepository);

        }

        private LocalContext LocalContext()
        {
            var options = new DbContextOptionsBuilder<LocalContext>()
                  .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                  .Options;

            return new LocalContext(options);
        }


        [Fact]
        public void CalculateTotalAmountOfNewOrder_WithoutDiscountedPrices_ReturnsCorrectTotalAmount()
        {
            // Arrange
            var items = new List<ProductCartObject>
            {
                new ProductCartObject { Price = 100, DiscountedPrice = 0,  Quantity = 1 },
                new ProductCartObject { Price = 200, DiscountedPrice = 0, Quantity = 2 }
            };
            var order = new OrderSchema
            {
                Items = items
            };
            var expectedResult = 500m;

            // Act
            var result = _sut.CalculateTotalAmountOfNewOrder(order);

            // Assert
            Assert.Equal(result.TotalAmount, expectedResult);
            
        }

        [Fact]
        public void CalculateTotalAmountOfNewOrder_WithDiscountedPrices_ReturnsCorrectTotalAmount()
        {
            // Arrange
            var items = new List<ProductCartObject>
            {
                new ProductCartObject { Price = 100, DiscountedPrice = 50,  Quantity = 1 },
                new ProductCartObject { Price = 200, DiscountedPrice = 100, Quantity = 2 }
            };
            var order = new OrderSchema
            {
                Items = items
            };
            var expectedResult = 250m;

            // Act
            var result = _sut.CalculateTotalAmountOfNewOrder(order);

            // Assert
            Assert.Equal(result.TotalAmount, expectedResult);

        }


    }
}
