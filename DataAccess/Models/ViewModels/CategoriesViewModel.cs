using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.ViewModels
{
    public class CategoriesViewModel
    {
        public int SelectedPrimaryCategory { get; set; }

	    public List<PrimaryCategory> PrimaryCategories { get; set; }

	    public List<SubCategory> SubCategories { get; set; }
    }
}
