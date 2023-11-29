using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Services.Abstractions
{
    public interface IPromotionService
    {
        Task<PromotionCode> GetPromotionCode(string promotionCodeNameQuery);

        decimal CalculatePromotionCodeDiscount(decimal discount, decimal totalValue);

    }
}
