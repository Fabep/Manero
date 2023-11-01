using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class ColorEntity
    {
        [Key]
        public int ColorId { get; set; }
        public string Color { get; set; }

    }
}
