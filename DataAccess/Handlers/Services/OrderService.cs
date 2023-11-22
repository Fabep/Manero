using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
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

        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }


        public async Task<Order> GetOneOrderFromOrderIdAsync(int id)
        {
            var orderEntity = await _orderRepository.GetAsync(x => x.OrderId == id);
            var order = DataConverter.ConvertOrderEntityToOrder(orderEntity);

            return order;
        }
        public async Task<List<OrderItem>> GetOrderItemsFromOrderIdAsync(int id)
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
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }

        public async Task<bool> CreateOrder(OrderSchema order)
        {
            try
            {
                // orderSchema till orderEntity gör om i en orderservice 
                var orderEntity = DataConverter.ConvertOrderSchemaToOrderEntity(order);
                orderEntity.Status = new OrderStatusEntity() { Status = "C" };

                // skapa order i databasen och hämta upp orderid från databasen innan orderitems läggs till.
                await SaveOrderEntityToDatabase(orderEntity);
                var orderFromDataBase = await GetOrderFromCustomerIdAsync(order.CustomerId);

                foreach (var item in order.Items)
                {
                    // orderitems är productCartObjet och ska sparas i databas som orderitem
                    var orderItemEntity = new OrderItemsEntity();
                    orderItemEntity.OrderId = orderFromDataBase.OrderId;
                    orderItemEntity.ProductId = item.ProductId;
                    orderItemEntity.ProductName = item.ProductName;
                    orderItemEntity.Quantity = item.Quantity;
                    orderItemEntity.DiscountPrice = item.DiscountedPrice; //är det priset eller är det procentsats?
                    orderItemEntity.TotalAmount = item.Quantity * item.Price;

                    // spara orderitems till databas
                    await SaveOrderItemEntityToDataBase(orderItemEntity);
                }
                return true;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message);  }
            return false;
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
            var orderEntity = await _orderRepository.GetAsync(x => x.CustomerId == customerId); // hämta order med customerId?
            var order = DataConverter.ConvertOrderEntityToOrder(orderEntity);
            return order;
        }

    }
}
