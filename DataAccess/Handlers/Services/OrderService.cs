using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.Schemas;
using DataAccess.Models.Entities;
using DataAccess.Models.Schemas;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public async Task<List<OrderItem>> GetOrderItemsFromOrderIdAsync(int id) // ta bort async eftersom det itne är en async metod?
        {
            var orderItems = new List<OrderItem>();
            var orderItemEntityQueryableList = _orderItemRepository.GetAll(x => x.OrderId == id);
            var orderItemEntityList = orderItemEntityQueryableList.ToList();

            foreach (var itemEntity in orderItemEntityList)
            {
                var item = DataConverter.ConvertOrderItemEntityToOrderItem(itemEntity);
                orderItems.Add(item);
            }

            return orderItems;
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
                var orderFromDataBase = await GetOrderFromCustomerIdAsync(order.CustomerId);

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
            catch (Exception ex) { Debug.WriteLine(ex.Message);  }
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

        public async Task<Order> GetOrderFromCustomerIdAsync(int customerId)
        {
            var orderEntity = await _orderRepository.GetAsync(x => x.CustomerId == customerId); 
            var order = DataConverter.ConvertOrderEntityToOrder(orderEntity);
            return order;
        }

    }
}
