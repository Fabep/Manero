using DataAccess.Models;
using DataAccess.Models.Entities;
using DataAccess.Models.Schemas;
using DataAccess.Models;
using DataAccess.Models.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Services.Abstractions
{
    public interface IOrderService
    {
        public Task<List<OrderItem>> GetOrderItemsFromOrderIdAsync(int id);
        public Task<Order> GetOneOrderFromOrderIdAsync(int id);
        public bool VerifyOrder(OrderSchema order);
        public Task<bool> CreateOrder(OrderSchema order);
        public Task SaveOrderEntityToDatabase(OrdersEntity orderEntity);
        public Task SaveOrderItemEntityToDataBase(OrderItemsEntity orderItemEntity);
        public Task<Order> GetOrderFromCustomerIdAsync(int customerId);

        Task<Order> GetOneOrderFromOrderIdAsync(int id);

        Task<List<OrderItem>> GetOrderItemsFromOrderIdAsync(int id);

        OrderSchema CalculateTotalAmountOfNewOrder(OrderSchema order);
    }
}
