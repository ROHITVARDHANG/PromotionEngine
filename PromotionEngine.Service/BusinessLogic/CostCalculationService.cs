using PromotionEngine.Service.Interfaces;
using PromotionEngine.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Service.BusinessLogic
{
    public class CostCalculationService : ICostCalculationService
    {
        // Method for initiating the logic for calculation of the total
        public decimal FetchTotal(IEnumerable<Item> items, IEnumerable<IPromotion> promotions)
        {
            foreach (var item in items)
            {
                if (item.Quantity != 0)
                {
                    break;
                }
                return 0;
            }

            var cartItems = new MyCart(items.ToList(), 0);

            foreach (var promotion in promotions)
            {
                cartItems = promotion.CheckPromotion(cartItems);
            }

            decimal balance = cartItems.TotalItems.Any() ? cartItems.TotalItems.Sum(x => x.Product.Price) : 0;

            return cartItems.Price + balance;
        }
    }
}
