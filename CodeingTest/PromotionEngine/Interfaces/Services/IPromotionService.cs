using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Interfaces.Services
{
    public interface IPromotionService
    {
        public List<IPromtion> GetActivePromotions();
    }
}
