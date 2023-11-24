using DataAccess.Models;
using DataAccess.Models.Entities;
using DataAccess.Models.Schemas;

namespace DataAccess.Handlers.Services.Abstractions
{
    public interface IOrderService
    {
      //  public List<OrderItem> GetOrderItemsFromOrderIdAsync(int id);
        public Task<Order> GetOneOrderFromOrderIdAsync(int id);
        public bool VerifyOrder(OrderSchema order);
        public Task<bool> CreateOrder(OrderSchema order);
        public Task SaveOrderEntityToDatabase(OrdersEntity orderEntity);
        public Task SaveOrderItemEntityToDataBase(OrderItemsEntity orderItemEntity);
        public Order GetOrderFromCustomerIdAsync(int customerId);
        OrderSchema CalculateTotalAmountOfNewOrder(OrderSchema order);
    }
}
