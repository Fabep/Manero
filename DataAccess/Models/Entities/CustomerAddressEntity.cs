using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
	public class CustomerAddressEntity
	{
		[Key]
		public int AddressId { get; set; } 
		public int CustomerId { get; set; } // [fk]
		public string? StreetAddress { get; set; }
		public string? Streetnumber { get; set; }
		public string? PostalCode { get; set; }
		public string? City { get; set; }
		public string? Region { get; set; }
		public string? Country { get; set; }
	}
}
