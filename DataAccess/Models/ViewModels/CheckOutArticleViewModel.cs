using DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.ViewModels
{
    public class CheckOutArticleViewModel
    {
        public Product Product { get; set; } = null!;
        public int CurrentAmount { get; set; } = 0;
        public SizeEnum Size { get; set; } 
        public string Color { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductDiscount { get; set; }

        //    public List<SizeColorCombination> Combinations { get; set; } = null!;

    }
}
