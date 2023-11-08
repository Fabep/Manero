using DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Size
    {
        public string? ProductName { get; set; }
        public SizeEnum SizeType { get; set; }
    }
}
