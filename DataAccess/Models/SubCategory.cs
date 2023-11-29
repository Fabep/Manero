using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
	public class SubCategory
	{
		public int SubCategoryId { get; set; }
		public string SubCategoryName { get; set; } = null!;
		public PrimaryCategoryEntity PrimaryCategory { get; set; } = null!;

	}
}
