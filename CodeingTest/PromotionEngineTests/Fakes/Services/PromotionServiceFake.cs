using PromotionEngine.Interfaces;
using PromotionEngine.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineTests.Fakes.Services
{
    public class PromotionServiceFake : IPromotionService
    {
        public List<IPromtion> Promtions { get; set; } = new List<IPromtion>();

        public List<IPromtion> GetActivePromotions()
        {
            return Promtions;
        }
    }
}
