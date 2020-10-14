using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Service.Models
{
	public class PromotionBulk
	{
		public string Name { get; set; }
		public int Quantity { get; set; }
		public decimal FixedPrice { get; set; }
		public PromotionBulk(string name, int quantity, decimal fixedPrice)
		{
			Name = name;
			Quantity = quantity;
			FixedPrice = fixedPrice;
		}
	}
}
