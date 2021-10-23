using PromotionEngine.Interfaces.Services;
using PromotionEngine.Models;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class PromotionCalculator
    {
        private readonly IPriceListService _priceService; 

        public PromotionCalculator(IPriceListService priceService)
        {
            _priceService = priceService;
        }

        public double CalculatePrice(List<CartItem> cartItems)
        {
            return 0;
        }

        //TODO: Change to internal and make internals visible for test project
        public double GetUnitPrice(string skuId)
        {
            var skuItem = _priceService.GetById(skuId);

            return skuItem.Price;
        }
        
    }
}
