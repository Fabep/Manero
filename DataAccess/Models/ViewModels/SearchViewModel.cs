﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.ViewModels
{
    public class SearchViewModel
    {
        public string Query { get; set; }
        public List<Product> Results { get; set; }
    }

}
