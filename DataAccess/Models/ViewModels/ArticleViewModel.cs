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


    }
}
