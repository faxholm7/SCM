using PromotionEngine.Exceptions;
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
            var total = (double)0;

            foreach (var cartItem in cartItems)
            {
                var itemTotal = (double)0;

                switch (cartItem.SKUId)
                {
                    case "A": //Non refined implemtation of 'n' Items promotion.
                        while (cartItem.Amount >= 3)
                        {
                            itemTotal += 130;
                            cartItem.Amount -= 3;
                        }
                        break;

                    case "B":
                        while (cartItem.Amount >= 2)
                        {
                            itemTotal += 45;
                            cartItem.Amount -= 2;
                        }
                        break;

                }

                //Calculating the totalt price for the current item, using the prices of the unit listede in eg. a database.
                var unitPrice = GetUnitPrice(cartItem.SKUId);
                itemTotal += unitPrice * cartItem.Amount;
                total += itemTotal;
            }

            return total;
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
