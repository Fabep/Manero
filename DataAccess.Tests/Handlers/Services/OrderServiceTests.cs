using DataAccess.Contexts;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Handlers.Services;
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
        private readonly OrderSchema _orderSchema = new OrderSchema
        {
            CustomerId = 1,
            BillingAddressSchema = new AddressSchema
            {
                City = "Waterloo",
                StreetAddress = "Avenue Messidor",
                Streetnumber = "19",
                Country = "Belgium",
                PostalCode = "56897",
                Region = "Walloon Region"
            },
            DeliveryAddressSchema = new AddressSchema
            {
                City = "Waterloo",
                StreetAddress = "Avenue Messidor",
                Streetnumber = "19",
                Country = "Belgium",
                PostalCode = "56897",
                Region = "Walloon Region"
            },
            PromotionDiscount = 0,
            TotalAmount = 500,
            PaymentMethod = new PaymentMethodSchema { CardNumber = 1 },
            Items = new List<ProductCartObject> { new ProductCartObject { ProductName = "T-shirt", Size = "M", Color = "blue", Quantity = 4, ImageUrl = "imageurl" } }
        };


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

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();

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

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();

        }


        [Fact]
        public void VerifyOrder_ReturnsTrue_IfOrderIsVerified()
        {
            //Arrange
      
            //Act
            var result = _sut.VerifyOrder(_orderSchema);

            //Assert
            Assert.IsType<bool>(result);
            Assert.True(result);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }

        [Fact]
        public void GetOrderFromCustomerIdAsync_ReturnsOrder_IfOrderIsCreated()
        {
            //Arrange
            _sut.CreateOrder(_orderSchema);

            //Act
            var result = _sut.GetOrderFromCustomerIdAsync(_orderSchema.CustomerId);

            //Assert
            Assert.IsType<Order>(result);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }

        [Fact]
        public void CreateOrder_ReturnsTrue_IfOrderIsCreated()
        {
            //Arrange

            //Act
            var result = _sut.CreateOrder(_orderSchema);

            //Assert
            Assert.IsType<Task<bool>>(result);
            Assert.True(result.Result);

            _localContext.Database.EnsureDeleted();
            _localContext.Dispose();
        }

    }
}
