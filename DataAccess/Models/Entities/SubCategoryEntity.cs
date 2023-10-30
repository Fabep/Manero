using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
   
        public class SubCategoryEntity
        {
            [Key]
            public int SubCategoryId { get; set; }
            public string SubCategoryName { get; set; } = null!;
            public int PrimaryCategoryId { get; set; }
            public PrimaryCategoryEntity PrimaryCategory { get; set; }
    }


}
