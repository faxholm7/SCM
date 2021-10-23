using PromotionEngine.Exceptions;
using PromotionEngine.Interfaces;
using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Promotions
{
    public class FixedPrice : BasePromotion
    {
        private readonly List<string> _skuIds;
        private readonly double _price;  
        /// <summary>
        /// Class for the fixed price promotion.
        /// </summary>
        /// <param name="activeSKUIds">List of the fixed price SKU Ids</param>
        /// <param name="price">Promotion price</param>
        public FixedPrice(List<string> activeSKUIds, double price)
        {
            _skuIds = activeSKUIds;
            _price = price;
        }

        protected override double CalculatePromotion(List<CartItem> cartItems)
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
