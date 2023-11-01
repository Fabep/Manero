using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.ViewModels
{
	public class HomeViewModel
	{
		public List<Product>? BestSellers { get; set; }
		public List<Product>? FeaturedProducts { get; set; } 

	}
}
