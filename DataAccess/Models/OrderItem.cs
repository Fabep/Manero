using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class OrderItem
    {
        public int OrderItermsId { get; set; }
        public int OrderId { get; set; }
        public OrdersEntity? Order { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DiscountPrice { get; set; }
        public int Quantity { get; set; }
    }
}
