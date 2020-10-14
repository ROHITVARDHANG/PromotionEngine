using PromotionEngine.Service.Interfaces;
using PromotionEngine.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Service.BusinessLogic
{
	public class PromotionBulkService : IPromotion
	{
		public PromotionBulk PromotionBulk { get; set; }
		public PromotionBulkService(PromotionBulk promotionBulk)
		{
			PromotionBulk = PromotionBulk;
		}

		// Method to check the case where the selection of items is in bulk for A or B
		// Applicable to Scenario B
		public MyCart CheckPromotion(MyCart cart)
		{
			var promotionalItems = cart.TotalItems.Where(item => item.Product.Name == PromotionBulk.Name).ToList();

			// returning the items in case of no promotions applied.
			if (promotionalItems.Count == 0)
			{
				return cart;
			}

			// Summation and comparison of the total items in cart with the promotional items.
			var totalItems = promotionalItems.Sum(item => item.Quantity);

			if (totalItems < PromotionBulk.Quantity)
			{
				return cart;
			}

			// Calculation of factor identification of the number of promotional groups applied to the total items and addition of the remaining costs.
			var promFactor = (int)Math.Floor((decimal)totalItems / PromotionBulk.Quantity);
			var total = promFactor * PromotionBulk.FixedPrice;
			var balance = totalItems - (promFactor * PromotionBulk.Quantity);
			total = total + balance * promotionalItems.FirstOrDefault().Product.Price;

			return new MyCart(cart.TotalItems.Except(promotionalItems).ToList(), cart.Price + total);
		}
	}

}
