using PromotionEngine.Exceptions;
using PromotionEngine.Interfaces;
using PromotionEngine.Interfaces.Services;
using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Promotions
{
    public class Percentage : BasePromotion
    {
        private readonly IPriceListService _priceListService;
        private readonly string _SKUId;
        private readonly double _percentageOff;

        public Percentage(IPriceListService priceListService, string skuId, double percentageOff)
        {
            _priceListService = priceListService;
            _SKUId = skuId;
            _percentageOff = percentageOff;
        }

        protected override double CalculatePromotion(List<CartItem> cartItems)
        {
            var totalOutput = (double)0;
            var currentItem = cartItems.SingleOrDefault(x => x.SKUId == _SKUId);

            if(currentItem != null)
            {
                var skuItem = _priceListService.GetById(currentItem.SKUId);

                if (skuItem == null)
                    throw new MissingItemException("Missing unit price");

                //Calculating the price for the amount of SKU's
                var priceTotal = skuItem.Price * currentItem.Amount;

                //Calculating the new price after the percentages has been removed.
                totalOutput = (priceTotal * _percentageOff) / 100;

                currentItem.Amount = 0;
            }

            return totalOutput;
        }
    }
}
