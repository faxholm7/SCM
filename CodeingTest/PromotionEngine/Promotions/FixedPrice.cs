using PromotionEngine.Interfaces;
using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Promotions
{
    public class FixedPrice : IPromtion
    {
        private readonly List<string> _skuIds;
        private readonly double _price;  

        public FixedPrice(List<string> activeSKUIds, double price)
        {
            _skuIds = activeSKUIds;
            _price = price;
        }

        public double UsePromotion(List<CartItem> cartItems)
        {
            var totalAmount = (double)0;

            var activeCartItems = cartItems.Where(x => _skuIds.Contains(x.SKUId) && x.Amount > 0).ToList();

            if (activeCartItems.Count() == _skuIds.Count)
            {
                while(activeCartItems.All(x=> x.Amount > 0))
                {
                    foreach (var item in _skuIds)
                    {
                        activeCartItems.Single(x => x.SKUId == item).Amount -= 1;
                    }
                    totalAmount += _price;
                }
            }
            return totalAmount;
        }
    }
}
