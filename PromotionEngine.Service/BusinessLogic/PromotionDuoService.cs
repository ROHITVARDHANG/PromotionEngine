using PromotionEngine.Service.Interfaces;
using PromotionEngine.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Service.BusinessLogic
{
    public class PromotionDuoService : IPromotion
    {
        public PromotionDuo PromotionDuo { get; private set; }

        public PromotionDuoService(PromotionDuo promotionDuo)
        {
            PromotionDuo = promotionDuo;
        }

        // Method to check the case where the selection of items is both C or D
        // Applicable to Scenario C
        public MyCart CheckPromotion(MyCart cart)
        {
            var items = cart.TotalItems.Where(x => PromotionDuo.Names.Any(c => c == x.Product.Name)).ToList();

            var numberDuos = PromotionDuo.Names.Select(x => items.Count(i => i.Product.Name == x)).Min();

            if (numberDuos == 0)
            {
                return cart;
            }

            var total = (PromotionDuo.FixedPrice * numberDuos);

            var calculatedItems = new List<Item>();

            foreach (var promotionName in PromotionDuo.Names)
            {
                calculatedItems.AddRange(items.Where(x => x.Product.Name == promotionName).Take(numberDuos));
            }

            var remaining = items.Except(calculatedItems);

            total += remaining.Any() ? remaining.Sum(x => x.Product.Price) : 0;

            return new MyCart(cart.TotalItems.Except(items).ToList(), cart.Price + total);
        }
    }
}
