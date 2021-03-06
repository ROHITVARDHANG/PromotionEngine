﻿using PromotionEngine.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Service.Interfaces
{
    public interface ICostCalculationService
    {
        decimal FetchTotal(IEnumerable<Item> items, IEnumerable<IPromotion> promotions);
    }
}
