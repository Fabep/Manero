using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
	public class PromotionEntity
	{
		[Key]
		public Guid PromotionId { get; set; }

		
		public string Name { get; set; }

		
		public string Description { get; set; }

		
		
		public decimal DiscountRate { get; set; }

		
		[DataType(DataType.Date)]
		public DateTime StartDate { get; set; }

		
		[DataType(DataType.Date)]
		public DateTime EndDate { get; set; }
	}
}
