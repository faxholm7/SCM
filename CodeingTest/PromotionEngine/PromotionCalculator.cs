using PromotionEngine.Exceptions;
using PromotionEngine.Interfaces;
using PromotionEngine.Interfaces.Services;
using PromotionEngine.Models;
using PromotionEngine.Promotions;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class PromotionCalculator
    {
        private readonly IPriceListService _priceService;
        private readonly IPromotionService _promotionService;

        public PromotionCalculator(IPriceListService priceService, IPromotionService promotionService)
        {
            _priceService = priceService;
            _promotionService = promotionService;
        }

        public double CalculatePrice(List<CartItem> cartItems)
        {
            var total = (double)0;

            //Calculating the price when applying each avaible promotion.
            //The amount for each SKU is lowered with each passing promotion. So only the "rest" wille be left for the final calculation.
            foreach (var promtion in _promotionService.GetActivePromotions())
            {
                total += promtion.UsePromotion(cartItems);
            }

            //Final calculation.
            foreach (var cartItem in cartItems)
            {
                //Calculating the totalt price for the current item, using the prices of the unit listede in eg. a database.
                var unitPrice = GetUnitPrice(cartItem.SKUId);
                var itemTotal = unitPrice * cartItem.Amount;
                total += itemTotal;
            }

            return total;
        }

        internal double GetUnitPrice(string skuId)
        {
            if (string.IsNullOrWhiteSpace(skuId))
                throw new EmptyIdException("Empty SKU ID."); 

            var skuItem = _priceService.GetById(skuId);

            if (skuItem == null)
                throw new MissingItemException("Non existing SKU ID.");

            return skuItem.Price;
        }
        
    }
}
