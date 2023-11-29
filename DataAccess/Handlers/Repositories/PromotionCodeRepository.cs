using DataAccess.Contexts;
using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Repositories
{
    public class PromotionCodeRepository : Repository<PromotionCodeEntity, LocalContext>
    {
        public PromotionCodeRepository(LocalContext context) : base(context)
        {
        }
    }
}
