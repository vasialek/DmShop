﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DmShop.Definition.Models
{
	public class ProductInStore
	{
		public int Id { get; set; }

		public string Code { get; set; }

		public string Name { get; set; }

		public string NameI18n { get; set; }

		public decimal Price { get; set; }
	}
}
