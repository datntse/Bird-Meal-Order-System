using ElectricStore_Datnt.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStore_Datnt
{
	public partial class Manager : Form
	{
		ProductService _productService;
		CategoryService _categoryService;

		public Manager()
		{
			_productService = new ProductService();
			_categoryService = new CategoryService();
			InitializeComponent();
		}

		private void Manager_Load(object sender, EventArgs e)
		{
			var result = from product in _productService.GetAll()
						 from category in _categoryService.GetAll()
						 where product.CategoryId.Equals(category.Id)
						 select new
						 {
							 productId = product.Id,
							 productName = product.ProductName,
							 productCode = product.ProductCode,
							 price = product.Price,
							 date = product.DateCreate.ToString(),
							 categoryId = category.Id,
							 categoryName = category.CategoryName,
						 };
			productDataView.DataSource = result.ToList();
		}

		private void createBtn_Click(object sender, EventArgs e)
		{

		}

		private void updateBtn_Click(object sender, EventArgs e)
		{

		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{

		}


	}
}
