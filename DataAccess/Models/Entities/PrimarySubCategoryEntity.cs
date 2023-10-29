using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class PrimarySubCategoryEntity
    {
        public int PrimaryCategoryId { get; set; }
        public PrimaryCategoryEntity PrimaryCategory{ get; set; } = null!;

        public int SubCategoryId { get; set; }
        public SubCategoryEntity SubCategory { get; set; } = null!;



    }
}
