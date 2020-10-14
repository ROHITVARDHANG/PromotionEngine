using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Service.Models
{
    public class Item
    {
		public ProductDTO Product { get; set; }

		public int Quantity { get; set; }

		public Item(ProductDTO product, int quantity)
		{
			Product = product;
			Quantity = quantity;
		}
	}
}
