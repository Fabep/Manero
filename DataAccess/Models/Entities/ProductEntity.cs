﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models.Entities;

public class ProductEntity
{
    [Key]
    public Guid ProductId = Guid.NewGuid();
    [Required]
    public string ProductName { get; set; } = null!;
    public string ProductDescription { get; set; } = null!;
    [Required]
    [Range(0, int.MaxValue)]
    public double ProductPrice { get; set; }
    public int? Rating { get; set; }
    public int? Quantity { get; set; }

    [ForeignKey("SubCategory")]
    public int SubCategoryId { get; set; }
    public SubCategoryEntity SubCategory { get; set; }

}
