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
        Task<Order> GetOneOrderFromOrderIdAsync(int id);

        Task<List<OrderItem>> GetOrderItemsFromOrderIdAsync(int id);

        OrderSchema CalculateTotalAmountOfNewOrder(OrderSchema order)
    }
}
