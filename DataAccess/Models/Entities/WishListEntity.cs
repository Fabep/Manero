using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
   public class WishListEntity
	{
		[Key]
		public int WishListId { get; set; } 
		public int CustomerId { get; set; } // [fk]
		public CustomerEntity? Customer { get; set; }
	}
}
