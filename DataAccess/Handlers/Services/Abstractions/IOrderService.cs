﻿using DataAccess.Models;
using DataAccess.Models.Entities;
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
        public Task SaveOrderToDatabase(OrdersEntity orderEntity);
    }
}
