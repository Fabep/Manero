using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models;

public class Product
{
	[Key]
	public Guid ProductId { get; set; }

	[Required]
	public string ProductName { get; set; } = null!;

	public string ProductDescription { get; set; } = null!;

	[Required]
	[Range(0, int.MaxValue)]
	public double ProductPrice { get; set; }

	public int? Rating { get; set; }
	public int? Quantity { get; set; }
	public string ImageUrl { get; set; } = null!;

	// Navigations-egenskap till PromotionEntity (nullable)
	public int? PromotionId { get; set; }
	[ForeignKey("PromotionId")]
	public Promotion? Promotion { get; set; }
	public double? DiscountedPrice { get; set; }

}
