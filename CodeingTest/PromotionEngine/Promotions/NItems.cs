using PromotionEngine.Interfaces;
using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Promotions
{
    public class NItems : IPromtion
    {
        private readonly string _skuId;
        private readonly int _noOfItems;
        private readonly double _price;
        /// <summary>
        /// Class for the 'n' items promotion.
        /// </summary>
        /// <param name="skuId">What ID the promotion should be active on.</param>
        /// <param name="noOfItems">No of items the promotion is active for.</param>
        /// <param name="price">The new price for the promotion.</param>
        public NItems(string skuId, int noOfItems, double price)
        {
            _skuId = skuId;
            _noOfItems = noOfItems;
            _price = price;
        }

        public double UsePromotion(List<CartItem> cartItems)
        {
            var currentCartItem = cartItems.SingleOrDefault(x => x.SKUId == _skuId);
            var outputTotal = (double)0;

            if (currentCartItem != null)
            {
                while (currentCartItem.Amount >= _noOfItems)
                {
                    outputTotal += _price;
                    currentCartItem.Amount -= _noOfItems;
                }
            }

            return outputTotal;
        }
    }
}
