using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models.Schemas;

public class ProductSchema
{
    public string ProductName { get; set; } = null!;
    [Required]
    public string ProductDescription { get; set; } = null!;
    [Required]
    [Range(0, int.MaxValue)]
    public decimal ProductPrice { get; set; }
    public int? Quantity { get; set; }
}
