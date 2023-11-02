using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
	public class Promotion
	{
		[Key]
		public int PromotionId { get; set; }

		[Required]
		[MaxLength(255)]
		public string Name { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		[RegularExpression(@"^\d+\.\d{0,2}$")]
		public double DiscountRate { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime StartDate { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime EndDate { get; set; }
	}
}
