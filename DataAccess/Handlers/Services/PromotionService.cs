using DataAccess.ExtensionMethods;
using DataAccess.Handlers.Repositories;
using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Services
{
    public class PromotionService : IPromotionService
    {

        private readonly PromotionCodeRepository _promotionCodeRepository;

        public PromotionService(PromotionCodeRepository promotionCodeRepository)
        {
            _promotionCodeRepository = promotionCodeRepository;
        }


        public async Task<PromotionCode> GetPromotionCode(string promotionCodeNameQuery)
        {
            var promotionCodeEntity = await _promotionCodeRepository.GetAsync(x => x.Name == promotionCodeNameQuery);

            var promotionCode = DataConverter.ConvertPromotionCodeEntityToPromotionCode(promotionCodeEntity);

            if (promotionCode != null)
                return promotionCode;

            return null!;

        }


        public decimal CalculatePromotionCodeDiscount(decimal discount, decimal totalValue)
        {
            return totalValue -= (1 - discount) * totalValue;
        }




    }
}
