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
        public int ProductInventoryId { get; set; }
        public int Quantity {get; set; }

    }
}
