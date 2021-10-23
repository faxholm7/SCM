using PromotionEngine.Interfaces.Services;
using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngineTests.Fakes.Services
{
    public class PriceListServiceFake : IPriceListService
    {
        public List<SKUItem> SKUItems { get; set; }

        public SKUItem GetById(string id)
        {
            return SKUItems.SingleOrDefault(x => x.SKUId == id);
        }
    }
}
