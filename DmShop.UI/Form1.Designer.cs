namespace DmShop.UI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listSalesProduct = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.numericSalesQuantity = new System.Windows.Forms.NumericUpDown();
			this.txtSalesSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtStoreCode = new System.Windows.Forms.TextBox();
			this.txtStoreName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtStoreNameI18n = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtStorePrice = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.listStoreProducts = new System.Windows.Forms.ListView();
			this.label7 = new System.Windows.Forms.Label();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericSalesQuantity)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(960, 546);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.listSalesProduct);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.numericSalesQuantity);
			this.tabPage1.Controls.Add(this.txtSalesSearch);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(952, 520);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Sales";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.BackColor = System.Drawing.Color.RoyalBlue;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(867, 486);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(77, 26);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "0.00";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(373, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "List of products";
			// 
			// listSalesProduct
			// 
			this.listSalesProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listSalesProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.listSalesProduct.FullRowSelect = true;
			this.listSalesProduct.GridLines = true;
			this.listSalesProduct.Location = new System.Drawing.Point(376, 24);
			this.listSalesProduct.Name = "listSalesProduct";
			this.listSalesProduct.Size = new System.Drawing.Size(568, 456);
			this.listSalesProduct.TabIndex = 4;
			this.listSalesProduct.UseCompatibleStateImageBehavior = false;
			this.listSalesProduct.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Picture";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Quantity";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Price";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.RoyalBlue;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(12, 51);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 40);
			this.button1.TabIndex = 2;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// numericSalesQuantity
			// 
			this.numericSalesQuantity.Location = new System.Drawing.Point(289, 23);
			this.numericSalesQuantity.Name = "numericSalesQuantity";
			this.numericSalesQuantity.Size = new System.Drawing.Size(44, 20);
			this.numericSalesQuantity.TabIndex = 1;
			// 
			// txtSalesSearch
			// 
			this.txtSalesSearch.Location = new System.Drawing.Point(9, 24);
			this.txtSalesSearch.Name = "txtSalesSearch";
			this.txtSalesSearch.Size = new System.Drawing.Size(273, 20);
			this.txtSalesSearch.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter product name/code";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.listStoreProducts);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(952, 520);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Store";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.txtStorePrice);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtStoreNameI18n);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtStoreName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtStoreCode);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(4, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(403, 275);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Product information";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Product code";
			// 
			// txtStoreCode
			// 
			this.txtStoreCode.Location = new System.Drawing.Point(6, 32);
			this.txtStoreCode.Name = "txtStoreCode";
			this.txtStoreCode.Size = new System.Drawing.Size(388, 20);
			this.txtStoreCode.TabIndex = 1;
			// 
			// txtStoreName
			// 
			this.txtStoreName.Location = new System.Drawing.Point(6, 72);
			this.txtStoreName.Name = "txtStoreName";
			this.txtStoreName.Size = new System.Drawing.Size(388, 20);
			this.txtStoreName.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Name (RU)";
			// 
			// txtStoreNameI18n
			// 
			this.txtStoreNameI18n.Location = new System.Drawing.Point(6, 111);
			this.txtStoreNameI18n.Name = "txtStoreNameI18n";
			this.txtStoreNameI18n.Size = new System.Drawing.Size(388, 20);
			this.txtStoreNameI18n.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 134);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Price";
			// 
			// txtStorePrice
			// 
			this.txtStorePrice.Location = new System.Drawing.Point(6, 150);
			this.txtStorePrice.Name = "txtStorePrice";
			this.txtStorePrice.Size = new System.Drawing.Size(115, 20);
			this.txtStorePrice.TabIndex = 7;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.RoyalBlue;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(240, 177);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(153, 40);
			this.button2.TabIndex = 8;
			this.button2.Text = "Create product";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// listStoreProducts
			// 
			this.listStoreProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.listStoreProducts.Location = new System.Drawing.Point(424, 23);
			this.listStoreProducts.Name = "listStoreProducts";
			this.listStoreProducts.Size = new System.Drawing.Size(520, 489);
			this.listStoreProducts.TabIndex = 1;
			this.listStoreProducts.UseCompatibleStateImageBehavior = false;
			this.listStoreProducts.View = System.Windows.Forms.View.Details;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(424, 7);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Available products";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Name";
			this.columnHeader5.Width = 200;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Name (RU)";
			this.columnHeader6.Width = 200;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Price";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 546);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Dima Shop";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericSalesQuantity)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView listSalesProduct;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown numericSalesQuantity;
		private System.Windows.Forms.TextBox txtSalesSearch;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtStorePrice;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtStoreNameI18n;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtStoreName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtStoreCode;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListView listStoreProducts;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
	}
}

