using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
	public class PaymentMethodEntity
	{
		[Key]
		public int PaymentId { get; set; } 
		public int CardNumber { get; set; }
	}
}
