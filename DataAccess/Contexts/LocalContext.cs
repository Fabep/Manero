using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    public class LocalContext : DbContext
    {
        public LocalContext(DbContextOptions<LocalContext> options) : base(options)
        {

        }
    }
}
