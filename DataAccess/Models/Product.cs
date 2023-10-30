using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class Product
{
    public Guid ProductId { get; set; } 
    public string ProductName { get; set; } = null!;
    [Required]
    public string ProductDescription { get; set; } = null!;
    [Required]
    [Range(0, int.MaxValue)]
    public double ProductPrice { get; set; }
    public int? Rating { get; set; }
    public int? Quantity { get; set; }
}
