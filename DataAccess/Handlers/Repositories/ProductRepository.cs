using DataAccess.Contexts;
using DataAccess.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Repositories
{
    public class ProductRepository : Repository<ProductEntity, LocalContext>
    {
        public ProductRepository(LocalContext context) : base(context)
        {
        }
    }
}
