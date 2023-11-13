using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
	public class CustomerEntity
	{
		[Key]
		public int CustomerId { get; set; } 
		public string? TelephoneNumber { get; set; } 
		public int PaymentMethod { get; set; } 
	}
}
