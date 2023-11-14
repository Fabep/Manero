using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    internal class OrderSeeder
    {
        private static readonly Random random = new Random();
        private static List<int> OrderIds = new List<int>();
        private static string[] Statuses = new string[] { "Created", "Confirmed", "Shipping", "Delivering", "Receiving" };

        internal static IEnumerable<OrdersEntity> SeedOrders()
        {
            var baseOrders = new List<OrdersEntity>();
            for (int i = 0; i < 5; i++)
            {
                var customerId = random.Next(0, 5);
                var orderAmount = random.Next(50, 10000);
                var cardNumber = random.Next(10000, 100000);

                OrdersEntity entity = new OrdersEntity()
                {
                    OrderId = i + 1,
                    CustomerId = customerId,
                    TotalAmount = orderAmount,
                    OrderDate = DateTime.Now,
                    PaymentMethod = $"Kortnr: {cardNumber}",
                    StatusId = 1 //random.Next(1, 6),
                };

                OrderIds.Add(entity.OrderId);
                baseOrders.Add(entity);
            }
            return baseOrders;
        }

        internal static IEnumerable<OrderItemsEntity> SeedOrderItems()
        {
            var orderItems = new List<OrderItemsEntity>();

            for (int i = 0; i < OrderIds.Count; i++)
            {
                OrderItemsEntity entity = new OrderItemsEntity()
                {
                    OrderItermsId = i + 1,
                    OrderId = OrderIds[i],
                    ProductId = i,
                    DiscountPrice = i,
                    ProductName = "T-shirt",
                    Quantity = random.Next(0, 10),
                    TotalAmount = i,
                };
                orderItems.Add(entity);
            }
            return orderItems;
        }


        internal static IEnumerable<OrderStatusEntity> SeedOrderStatus()
        {
            var statusList = new List<OrderStatusEntity>();
            for (int i = 0; i < Statuses.Length; i++)
            {
                var entity = new OrderStatusEntity()
                {
                    StatusId = i+1,
                    Status = GetStatusFrom(i+1),
                };
                statusList.Add(entity);
            }
            return statusList;
        }

        internal static string GetStatusFrom(int statusId)
        {
            switch (statusId)
            {
                case 1:
                    return Statuses[0];
                case 2:
                    return Statuses[1];
                case 3:
                    return Statuses[2];
                case 4:
                    return Statuses[3];
                case 5:
                    return Statuses[4];
                default:
                    return "";
            }
        }
    }
}
