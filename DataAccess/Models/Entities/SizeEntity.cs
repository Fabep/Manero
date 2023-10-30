using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class SizesEntity
    {
        [Key]
        public int SizeId { get; set; }
        public string Size { get; set; }

    }
}
