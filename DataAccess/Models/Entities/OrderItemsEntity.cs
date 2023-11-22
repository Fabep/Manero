using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
	public class OrderItemsEntity
	{
		[Key]
        public int OrderItemsId { get; set; }
        public int OrderId { get; set; }
		public OrdersEntity? Order { get; set; }
		public Guid ProductId { get; set; }
		public string? ProductName { get; set; }
		[Required, Column(TypeName = "money")] public decimal TotalAmount { get; set; }
        [Required, Column(TypeName = "money")] public decimal DiscountPrice { get; set; }
		public int Quantity { get; set; }
	}
}
