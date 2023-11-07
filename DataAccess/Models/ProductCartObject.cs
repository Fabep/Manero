using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ProductCartObject
    {
        public string Id { get; set; } = null!;
        public int Quantity { get; set; }
    }
}
