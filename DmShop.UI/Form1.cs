using DmShop.Definition.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DmShop.UI
{
	public partial class Form1 : Form
	{
		private IList<ProductInStore> _productsInStore = new List<ProductInStore>();

		public Form1()
		{
			InitializeComponent();


			var productsInCart = new List<ProductInCart>();
			productsInCart.Add(new ProductInCart { Name = "Milk", Barcode = "123456001", Price = 1.79m });
			productsInCart.Add(new ProductInCart { Name = "Bread", Barcode = "123456002", Price = 1.15m, Quantity = 2 });

			DrawSalesProducts(productsInCart);
		}

		private void DrawSalesProducts(ICollection<ProductInCart> products)
		{
			foreach (var p in products)
			{
				listSalesProduct.Items.Add(new ListViewItem(new string[] { p.Name, p.Price.ToString(), p.Quantity.ToString() }));
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Add new product to store
			string s = txtStorePrice.Text.Trim();
			decimal price = 0;
			Decimal.TryParse(s, out price);

			var p = new ProductInStore
			{
				Code = txtStoreCode.Text.Trim(),
				Name = txtStoreName.Text.Trim(),
				NameI18n = txtStoreNameI18n.Text.Trim(),
				Price = price,
			};

			_productsInStore.Add(p);
			DrawStoreProducts(_productsInStore);
		}

		private void DrawStoreProducts(ICollection<ProductInStore> products)
		{
			foreach (var p in products)
			{
				listStoreProducts.Items.Add(new ListViewItem(new string[] { p.Name, p.NameI18n, p.Price.ToString() }));
			}
		}
	}
}
