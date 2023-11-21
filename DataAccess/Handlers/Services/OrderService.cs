using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
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

        public async Task SaveOrderToDatabase(OrdersEntity orderEntity)
        {
            await _orderRepository.CreateAsync(orderEntity);
        }

        public async Task GetOrderIdAsync(int customerId)
        {
            await _orderRepository.GetAsync(x => x.CustomerId == customerId); // hämta order med customerId?
        }

    }
}
