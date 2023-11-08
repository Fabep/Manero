using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models.Entities;

public class ProductEntity
{
    [Key]
    public Guid ProductId { get; set; } = Guid.NewGuid();
    [Required]
    public string ProductName { get; set; } = null!;
    public string ProductDescription { get; set; } = null!;
    [Required]
    [Range(0, int.MaxValue)]
    public double ProductPrice { get; set; }
    public int? Rating { get; set; }
    public int? Quantity { get; set; }

    public int? SubCategoryId { get; set; }
    [Required]
    public SubCategoryEntity? SubCategory { get; set; }

    public int? ColorId { get; set; }
    public ColorEntity? Color { get; set; }

    public int? SizeId { get; set; }

    public SizeEntity? Size { get; set; }

    public ProductInventoryEntity? ProductInventory { get; set; }

	// Navigations-egenskap till PromotionEntity (nullable)
	public int? PromotionId { get; set; }
	[ForeignKey("PromotionId")]
	public PromotionEntity? Promotion { get; set; }
    public bool? IsBestSeller { get; set; }
    public bool? IsFeaturedProduct { get; set; }
}
