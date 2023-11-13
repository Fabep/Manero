using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
	public class OrdersEntity
	{
		[Key]
		public int OrderId { get; set; } 
		public int CustomerId { get; set; } // [fk]
		public double TotalPrice { get; set; }
		public DateTime? OrderDate { get; set; }
		public string? PaymentMethod { get; set; }
		public int? OrderStatus { get; set; } 
	}
}
