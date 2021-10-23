using PromotionEngine.Interfaces;
using PromotionEngine.Interfaces.Services;
using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Promotions
{
    public class Percentage : IPromtion
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

        public double UsePromotion(List<CartItem> cartItems)
        {
            throw new NotImplementedException();
        }
    }
}
