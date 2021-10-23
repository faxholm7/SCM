using PromotionEngineTests.Fakes.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineTests.PromotionCalculatorTests
{
    public static class Helpers
    {
        public static PriceListServiceFake GetBasicPriceListServiceFake()
        {
            var service = new PriceListServiceFake();
            service.SKUItems.Add(new PromotionEngine.Models.SKUItem() { SKUId = "A", Price = 50, Description = string.Empty });
            service.SKUItems.Add(new PromotionEngine.Models.SKUItem() { SKUId = "B", Price = 30, Description = string.Empty });
            service.SKUItems.Add(new PromotionEngine.Models.SKUItem() { SKUId = "C", Price = 20, Description = string.Empty });
            service.SKUItems.Add(new PromotionEngine.Models.SKUItem() { SKUId = "D", Price = 15, Description = string.Empty });

            return service;
        }
    }
}
