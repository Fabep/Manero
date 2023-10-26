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
            [Key]
            public int ProductCategoryID { get; set; }
            public string ProductCategoryName { get; set; }

            public ICollection<MainCategoryEntity> MainCategories { get; set; }
        }


}
