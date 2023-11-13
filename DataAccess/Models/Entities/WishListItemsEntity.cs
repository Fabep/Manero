using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
	public class WishListItemsEntity
	{

		[Key]
		public int WishListId { get; set; } 

		public int ProductId { get; set; } // [fk]
	}
}
