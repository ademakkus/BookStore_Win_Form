using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBookStore
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		ProductDAL _productDAL = new ProductDAL();
		private void Form1_Load(object sender, EventArgs e)
		{
			LoadProducts();
		}

		private void LoadProducts()
		{
			dgwProducts.DataSource = _productDAL.GetAll();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			string productName = textBox1.Text;
			_productDAL.Add(new Product
			{
				Name = textBox1.Text,
				UnitPrice = Convert.ToInt32(textBox2.Text),
				StockAmount=Convert.ToInt32(textBox3.Text)
			});
			LoadProducts();
			MessageBox.Show($"Product {productName} Adding.","Product added");
		}

	

		private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Update(dgwProducts);
		}
		private void Update(DataGridView dgv)
		{

			tbxNameUpdate.Text = dgv.CurrentRow.Cells[1].Value.ToString();
			tbxUnitPriceUpdate.Text = dgv.CurrentRow.Cells[2].Value.ToString();
			tbxStockAmountUpdate.Text = dgv.CurrentRow.Cells[3].Value.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			Product product = new Product
			{
				Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
				Name=tbxNameUpdate.Text,
				UnitPrice=Convert.ToInt32(tbxUnitPriceUpdate.Text),
				StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)

			};
			_productDAL.Update(product);
			LoadProducts();
			MessageBox.Show($"{tbxNameUpdate.Text} güncellendi.","Güncelleme İşlemi");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
			_productDAL.Delete(id);
			LoadProducts();
			MessageBox.Show("Product deleted");
		}
	}
}
