using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class PrimaryCategoryEntity
    {
        [Key]
        public int PrimaryCategoryId { get; set; }
        public string PrimaryCategoryName { get; set; } = null!;
        

    }
}
