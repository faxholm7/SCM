using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Interfaces.Services
{
    public interface IPriceListService
    {
        public SKUItem GetById(string id);
    }
}
