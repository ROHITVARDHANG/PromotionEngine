using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Service.Models
{
    public class PromotionDuo
    {
        public IEnumerable<string> Names { get; set; }
        public decimal FixedPrice { get; set; }
        public PromotionDuo(IEnumerable<string> names, decimal fixedPrice)
        {
            Names = names;
            FixedPrice = fixedPrice;
        }
    }
}
