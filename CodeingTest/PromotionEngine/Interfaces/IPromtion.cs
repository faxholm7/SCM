using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Interfaces
{
    public interface IPromtion
    {
        public double UsePromotion(List<CartItem> cartItems);
    }
}
