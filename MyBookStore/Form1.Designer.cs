namespace MyBookStore
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
			this.dgwProducts = new System.Windows.Forms.DataGridView();
			this.lblName = new System.Windows.Forms.Label();
			this.lblUnitPrice = new System.Windows.Forms.Label();
			this.lblStockAmount = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.gbxAdd = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gbxUpdate = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblNameUpdate = new System.Windows.Forms.Label();
			this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
			this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
			this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
			this.lblStockAmountUpdate = new System.Windows.Forms.Label();
			this.tbxNameUpdate = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
			this.gbxAdd.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.gbxUpdate.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgwProducts
			// 
			this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwProducts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgwProducts.Location = new System.Drawing.Point(3, 18);
			this.dgwProducts.Name = "dgwProducts";
			this.dgwProducts.RowHeadersWidth = 51;
			this.dgwProducts.RowTemplate.Height = 24;
			this.dgwProducts.Size = new System.Drawing.Size(843, 172);
			this.dgwProducts.TabIndex = 0;
			this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblName.ForeColor = System.Drawing.Color.Black;
			this.lblName.Location = new System.Drawing.Point(30, 49);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(57, 20);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name";
			// 
			// lblUnitPrice
			// 
			this.lblUnitPrice.AutoSize = true;
			this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblUnitPrice.ForeColor = System.Drawing.Color.Black;
			this.lblUnitPrice.Location = new System.Drawing.Point(30, 87);
			this.lblUnitPrice.Name = "lblUnitPrice";
			this.lblUnitPrice.Size = new System.Drawing.Size(93, 20);
			this.lblUnitPrice.TabIndex = 2;
			this.lblUnitPrice.Text = "Unit Price";
			// 
			// lblStockAmount
			// 
			this.lblStockAmount.AutoSize = true;
			this.lblStockAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblStockAmount.ForeColor = System.Drawing.Color.Black;
			this.lblStockAmount.Location = new System.Drawing.Point(30, 134);
			this.lblStockAmount.Name = "lblStockAmount";
			this.lblStockAmount.Size = new System.Drawing.Size(125, 20);
			this.lblStockAmount.TabIndex = 3;
			this.lblStockAmount.Text = "Stock Amount";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(178, 49);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(161, 28);
			this.textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(178, 87);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(161, 28);
			this.textBox2.TabIndex = 5;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(178, 134);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(161, 28);
			this.textBox3.TabIndex = 6;
			// 
			// gbxAdd
			// 
			this.gbxAdd.BackColor = System.Drawing.Color.LightGray;
			this.gbxAdd.Controls.Add(this.button1);
			this.gbxAdd.Controls.Add(this.lblName);
			this.gbxAdd.Controls.Add(this.textBox3);
			this.gbxAdd.Controls.Add(this.lblUnitPrice);
			this.gbxAdd.Controls.Add(this.textBox2);
			this.gbxAdd.Controls.Add(this.lblStockAmount);
			this.gbxAdd.Controls.Add(this.textBox1);
			this.gbxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gbxAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.gbxAdd.Location = new System.Drawing.Point(29, 211);
			this.gbxAdd.Name = "gbxAdd";
			this.gbxAdd.Size = new System.Drawing.Size(412, 285);
			this.gbxAdd.TabIndex = 7;
			this.gbxAdd.TabStop = false;
			this.gbxAdd.Text = "Add a product";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(133, 187);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(138, 54);
			this.button1.TabIndex = 7;
			this.button1.Text = "ADD";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgwProducts);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(849, 193);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// gbxUpdate
			// 
			this.gbxUpdate.BackColor = System.Drawing.Color.PeachPuff;
			this.gbxUpdate.Controls.Add(this.button2);
			this.gbxUpdate.Controls.Add(this.btnUpdate);
			this.gbxUpdate.Controls.Add(this.lblNameUpdate);
			this.gbxUpdate.Controls.Add(this.tbxStockAmountUpdate);
			this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
			this.gbxUpdate.Controls.Add(this.tbxUnitPriceUpdate);
			this.gbxUpdate.Controls.Add(this.lblStockAmountUpdate);
			this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
			this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gbxUpdate.ForeColor = System.Drawing.Color.Red;
			this.gbxUpdate.Location = new System.Drawing.Point(447, 220);
			this.gbxUpdate.Name = "gbxUpdate";
			this.gbxUpdate.Size = new System.Drawing.Size(423, 285);
			this.gbxUpdate.TabIndex = 9;
			this.gbxUpdate.TabStop = false;
			this.gbxUpdate.Text = "Update a product";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(105, 178);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(138, 54);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "UPDATE";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblNameUpdate
			// 
			this.lblNameUpdate.AutoSize = true;
			this.lblNameUpdate.Location = new System.Drawing.Point(12, 49);
			this.lblNameUpdate.Name = "lblNameUpdate";
			this.lblNameUpdate.Size = new System.Drawing.Size(52, 18);
			this.lblNameUpdate.TabIndex = 1;
			this.lblNameUpdate.Text = "Name";
			// 
			// tbxStockAmountUpdate
			// 
			this.tbxStockAmountUpdate.Location = new System.Drawing.Point(143, 134);
			this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
			this.tbxStockAmountUpdate.Size = new System.Drawing.Size(161, 24);
			this.tbxStockAmountUpdate.TabIndex = 6;
			// 
			// lblUnitPriceUpdate
			// 
			this.lblUnitPriceUpdate.AutoSize = true;
			this.lblUnitPriceUpdate.Location = new System.Drawing.Point(12, 87);
			this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
			this.lblUnitPriceUpdate.Size = new System.Drawing.Size(82, 18);
			this.lblUnitPriceUpdate.TabIndex = 2;
			this.lblUnitPriceUpdate.Text = "Unit Price";
			// 
			// tbxUnitPriceUpdate
			// 
			this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(143, 87);
			this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
			this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(161, 24);
			this.tbxUnitPriceUpdate.TabIndex = 5;
			// 
			// lblStockAmountUpdate
			// 
			this.lblStockAmountUpdate.AutoSize = true;
			this.lblStockAmountUpdate.Location = new System.Drawing.Point(12, 134);
			this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
			this.lblStockAmountUpdate.Size = new System.Drawing.Size(114, 18);
			this.lblStockAmountUpdate.TabIndex = 3;
			this.lblStockAmountUpdate.Text = "Stock Amount";
			// 
			// tbxNameUpdate
			// 
			this.tbxNameUpdate.Location = new System.Drawing.Point(143, 49);
			this.tbxNameUpdate.Name = "tbxNameUpdate";
			this.tbxNameUpdate.Size = new System.Drawing.Size(161, 24);
			this.tbxNameUpdate.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(276, 178);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(138, 54);
			this.button2.TabIndex = 8;
			this.button2.Text = "DELETE";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 543);
			this.Controls.Add(this.gbxUpdate);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.gbxAdd);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
			this.gbxAdd.ResumeLayout(false);
			this.gbxAdd.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.gbxUpdate.ResumeLayout(false);
			this.gbxUpdate.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwProducts;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblUnitPrice;
		private System.Windows.Forms.Label lblStockAmount;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox gbxAdd;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox gbxUpdate;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblNameUpdate;
		private System.Windows.Forms.TextBox tbxStockAmountUpdate;
		private System.Windows.Forms.Label lblUnitPriceUpdate;
		private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
		private System.Windows.Forms.Label lblStockAmountUpdate;
		private System.Windows.Forms.TextBox tbxNameUpdate;
		private System.Windows.Forms.Button button2;
	}
}

