using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DmShop.Definition.Models
{
	public class ProductInCart
	{
		public int Id { get; set; }

		public int ProductId { get; set; }

		public string Barcode { get; set; }

		public string Name { get; set; }

		public decimal Price { get; set; }

		public int Quantity { get; set; } = 1;
	}
}
