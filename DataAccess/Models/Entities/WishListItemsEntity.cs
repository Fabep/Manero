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
		public int WishListItemId { get; set; }
		public int WishListId { get; set; } 
		public WishListEntity? WishList { get; set; }
		public int ProductId { get; set; }



	}
}
