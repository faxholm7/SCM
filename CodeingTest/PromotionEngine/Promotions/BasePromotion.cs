using PromotionEngine.Exceptions;
using PromotionEngine.Interfaces;
using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Promotions
{
    public abstract class BasePromotion : IPromtion
    {
        public double UsePromotion(List<CartItem> cartItems)
        {
            ValidateCartItems(cartItems);
            return CalculatePromotion(cartItems);
        }

        protected abstract double CalculatePromotion(List<CartItem> cartItems);

        internal void ValidateCartItems(List<CartItem> cartItems)
        {
            if (cartItems.Select(x => x.SKUId).Where(y => string.IsNullOrEmpty(y)).Any())
                throw new EmptyIdException("Empty SKU ID.");
        }
    }
}
