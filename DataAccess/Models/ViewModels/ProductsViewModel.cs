using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.ViewModels
{
	public class ProductsViewModel
	{
		public string PageTitle { get; set; }

		public List<Product> ProductList { get; set; }
	}
}
