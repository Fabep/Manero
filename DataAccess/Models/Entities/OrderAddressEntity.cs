using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
	public class OrderAddressEntity
	{
		[Key]
		public int Id { get; set; } 
		public int OrderId { get; set; } // [fk]
		public string? AddressType { get; set; }
		public string? StreetAddress { get; set; }
		public string? Streetnumber { get; set; }
		public string? PostalCode { get; set; }
		public string? City { get; set; }
		public string? Region { get; set; }
		public string? Country { get; set; }
	}
}
