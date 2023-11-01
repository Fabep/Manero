using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccess.Models.Entities;

public class ProductEntity
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public Guid ProductId { get; set; }

	[Required]
	public string ProductName { get; set; } = null!;

	public string ProductDescription { get; set; } = null!;

	[Required]
	[Range(0, int.MaxValue)]
	public double ProductPrice { get; set; }

	public int? Rating { get; set; }
	public int? Quantity { get; set; }

	// Navigations-egenskap till PromotionEntity (nullable)
	public int? PromotionId { get; set; }
	[ForeignKey("PromotionId")]
	public PromotionEntity? Promotion { get; set; }
	public double? DiscountedPrice { get; set; }
}
