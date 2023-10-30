using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class ProductInventoryEntity
    {
        [Key]
        public Guid ProductId { get; set; }
        public ProductEntity Product { get; set; }
        public int Quantity {get; set; }
        public DateTime LastInventory { get; set; }

    }
}
