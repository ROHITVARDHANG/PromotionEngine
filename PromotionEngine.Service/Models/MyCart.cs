using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Service.Models
{
    public class MyCart
    {
		public IEnumerable<Item> TotalItems { get; set; }

		public decimal Price { get; set; }

		public MyCart(IEnumerable<Item> items, decimal total)
		{
			TotalItems = items;
			Price = total;
		}
	}
}
