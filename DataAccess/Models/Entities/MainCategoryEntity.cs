using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class MainCategoryEntity
    {
        [Key]
        public int MainCategoryID { get; set; }
        public string MainCategoryName { get; set; }
        public virtual ICollection<ProductCategoryEntity> ProductCategories { get; set; }
    }
}
