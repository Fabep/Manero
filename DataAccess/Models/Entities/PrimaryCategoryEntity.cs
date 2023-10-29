using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class PrimaryCategoryEntity
    {
        [Key]
        public int PrimaryCategoryId { get; set; }
        public string Name { get; set; } = null!;
    }
}
