using DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.ViewModels
{
    public class ArticleViewModel
    {
        public Product Product { get; set; } = null!;
        public int ReviewCount { get; set; } = 0;
        public int CurrentAmount { get; set; } = 0;
        public List<SizeEnum> Sizes { get; set; } = new List<SizeEnum>();
        public List<string> Colors { get; set; } = new List<string>();
        public List<(SizeEnum, string)> Combinations { get; set; } = null!;


    }
}
