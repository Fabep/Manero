using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.Schemas;
using DataAccess.Models.Entities;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Handlers.Services
{
    public class OrderService : IOrderService
    {

        private readonly OrderRepository _orderRepository;
        private readonly OrderItemRepository _orderItemRepository;

        public OrderService(OrderRepository orderRepository, OrderItemRepository orderItemRepository)
        {
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
        }


        public async Task<Order> GetOneOrderFromOrderIdAsync(int id)
        {
            var orderEntity = await _orderRepository.GetAsync(x => x.OrderId == id);
            var order = DataConverter.ConvertOrderEntityToOrder(orderEntity);

            return order;
        }


        public bool VerifyOrder(OrderSchema order)
        {
            try
            {
                if (order.PaymentMethod != null && order.TotalAmount > 0 && order.BillingAddressSchema != null
                               && order.DeliveryAddressSchema != null && order.Items?.Count > 0)
                    return true;
                else return false;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }

        public async Task<bool> CreateOrder(OrderSchema order)
        {
            try
            {
                var orderEntity = DataConverter.ConvertOrderSchemaToOrderEntity(order);
                orderEntity.Status = new OrderStatusEntity() { Status = "C" };

                await SaveOrderEntityToDatabase(orderEntity);
                var orderFromDataBase = GetOrderFromCustomerIdAsync(order.CustomerId);

                foreach (var item in order.Items)
                {
                    var orderItemEntity = new OrderItemsEntity();
                    orderItemEntity.OrderId = orderFromDataBase.OrderId;
                    orderItemEntity.Order = orderEntity;
                    orderItemEntity.ProductId = item.ProductId;
                    orderItemEntity.ProductName = item.ProductName;
                    orderItemEntity.Quantity = item.Quantity;
                    orderItemEntity.DiscountPrice = item.DiscountedPrice;
                    orderItemEntity.TotalAmount = item.Quantity * item.Price;

                    await SaveOrderItemEntityToDataBase(orderItemEntity);
                }
                return true;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }


        public OrderSchema CalculateTotalAmountOfNewOrder(OrderSchema order)
        {

            foreach (var item in order.Items!)
            {
                if (item.DiscountedPrice > 0)
                    order.TotalAmount += item.DiscountedPrice * item.Quantity;
                else
                    order.TotalAmount += item.Price * item.Quantity;
            }

            return order;
        }
        public async Task SaveOrderEntityToDatabase(OrdersEntity orderEntity)
        {
            await _orderRepository.CreateAsync(orderEntity);
        }

        public async Task SaveOrderItemEntityToDataBase(OrderItemsEntity orderItemEntity)
        {
            await _orderItemRepository.CreateAsync(orderItemEntity);
        }

        public Order GetOrderFromCustomerIdAsync(int customerId)
        {
            try
            {
                var orderEntity = _orderRepository.GetAll(x => x.CustomerId == customerId)
                .Include(x => x.PaymentMethod)
                .Include(x => x.Status)
                .FirstOrDefault();

                var order = DataConverter.ConvertOrderEntityToOrder(orderEntity);
                if(order != null)
                    return order;
                return null!;
            }
            catch (Exception) { }
            return null!;
        }

        public AddressSchema CreateAddressSchema()
        {
            return new AddressSchema
            {
                StreetAddress = "Långholmsvägen",
                Streetnumber = "1",
                City = "Stockholm",
                Country = "Sweden",
                PostalCode = "70171",
                Region = "County of Stockholm",
            };
        }

        public PaymentMethodSchema CreatePaymentSchema()
        {
            return new PaymentMethodSchema
            {
                CardNumber = 1432523,
            };
        }
    }
}
