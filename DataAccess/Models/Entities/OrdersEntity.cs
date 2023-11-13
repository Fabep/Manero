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
	public class OrdersEntity
	{
		[Key]
		public int OrderId { get; set; } 
		public int CustomerId { get; set; }
		[Required, Column(TypeName = "money")] public decimal TotalAmount { get; set; }
		public DateTime? OrderDate { get; set; }
		public string? PaymentMethod { get; set; }
		public int? StatusId { get; set; }
        public OrderStatusEntity? Status { get; set; }

    }
}
