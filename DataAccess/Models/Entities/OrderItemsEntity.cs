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
		public int Id { get; set; }
		public int ProductId { get; set; } // [fk]
		public string? ProductName { get; set; }
		[Required, Column(TypeName = "money")] public decimal TotalAmount { get; set; }
		public double DiscountPrice { get; set; }
		public int Quantity { get; set; }
	}
}
