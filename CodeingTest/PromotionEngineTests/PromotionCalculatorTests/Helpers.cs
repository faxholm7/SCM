using PromotionEngine.Promotions;
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

        public static PromotionServiceFake GetPromotionServiceFake(bool nItemsA = false, bool nItemsB = false, bool cdFixed = false)
        {
            var service = new PromotionServiceFake();
            if(nItemsA)
                service.Promtions.Add(new NItems("A", 3, 130));
            if(nItemsB)
                service.Promtions.Add(new NItems("B", 2, 45));
            
            return service;
        }
    }
}
