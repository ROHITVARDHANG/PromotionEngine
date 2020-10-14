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
		public decimal FetchTotal(IEnumerable<Item> items, IEnumerable<IPromotion> promotions)
		{
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
