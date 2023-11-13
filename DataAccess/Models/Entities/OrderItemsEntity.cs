using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
	public class OrderItemsEntity
	{
		[Key]
		public int Id { get; set; }
		public int ProductId { get; set; } // [fk]
		public string? ProductName { get; set; }
		public double ProductPrice { get; set; }
		public double DiscountPrice { get; set; }
		public int Quantity { get; set; }
	}
}
