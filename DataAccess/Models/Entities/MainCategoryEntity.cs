using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.Models.Entities.ProductCategoryEntity;

namespace DataAccess.Models.Entities
{
    public class MainCategory
    {
        [Key]
        public int MainCategoryID { get; set; }
        public string MainCategoryName { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
