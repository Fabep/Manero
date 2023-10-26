using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class ProductCategoryEntity
    {
        public class ProductCategory
        {
            [Key]
            public int ProductCategoryID { get; set; }
            public string ProductCategoryName { get; set; }

            public ICollection<MainCategory> MainCategories { get; set; }
        }



    }
}
