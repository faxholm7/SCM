﻿using PromotionEngine.Exceptions;
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
            if (string.IsNullOrWhiteSpace(skuId))
                throw new EmptyIdException("Empty SKU ID."); //TODO: Think about changeing the exception implemtation, so only the kind of ID is specifed in the message.

            var skuItem = _priceService.GetById(skuId);

            if (skuItem == null)
                throw new MissingItemException("Non existing SKU ID.");

            return skuItem.Price;
        }
        
    }
}
