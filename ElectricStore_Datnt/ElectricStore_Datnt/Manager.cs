using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Services;
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
		CategoryService _categoryService;
		ProductService _productService;
		public Manager()
		{
			_categoryService = new CategoryService();
			_productService = new ProductService();
			InitializeComponent();

			txtProductId.Enabled = false;

			var categoryList = _categoryService.GetAll().ToList();
			var productList = _productService.GetAll().Include(p => p.Category).Select(p => new
			{
				p.Id,
				p.ProductCode,
				p.ProductName,
				p.Price,
				p.DateCreate,
				Category = p.Category.CategoryName
			}).ToList();

			cbCategory.DisplayMember = "CategoryName";
			cbCategory.ValueMember = "Id";
			cbCategory.DataSource = categoryList;

			dgvProductList.DataSource = new BindingSource()
			{
				DataSource = productList
			};
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			var productCode = txtSearch.Text.ToString();
			if (string.IsNullOrEmpty(productCode))
			{
				MessageBox.Show("No ProductCode found", "Message", MessageBoxButtons.OK);
			}
			else
			{
				var producList = _productService.GetAll().Where(p => p.ProductCode.Contains(productCode)).Include(p => p.Category).Select(p => new
				{
					p.Id,
					p.ProductCode,
					p.ProductName,
					p.Price,
					p.DateCreate,
					Category = p.Category.CategoryName
				}).ToList();
				dgvProductList.DataSource = producList;
			}
		}
		private void dgvProductList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var _producList = _productService.GetAll();
			var selectedRow = dgvProductList.Rows[e.RowIndex];

			// Kiểm tra giá trị RowIndex hợp lệ
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < 100)
			{
				var productId = selectedRow.Cells[0].Value.ToString();
				var productCode = selectedRow.Cells[1].Value.ToString();
				var productName = selectedRow.Cells[2].Value.ToString();
				var price = selectedRow.Cells[3].Value.ToString();
				var dateCreate = selectedRow.Cells[4].Value.ToString();
				var Category = selectedRow.Cells[5].Value.ToString();
				cbCategory.Text = Category;

				var selectedCategory = _categoryService.GetAll().FirstOrDefault(t => t.CategoryName == Category);
				txtProductId.Text = productId;
				txtProductCode.Text = productCode;
				txtProductName.Text = productName;
				txtPrice.Text = price;
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtProductId.Text = "";
			txtProductCode.Text = "";
			txtSearch.Text = "";
			txtProductName.Text = "";
			txtPrice.Text = "";
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var productList = _productService.GetAll().ToList();
			var productID = txtProductId.Text;
			bool flag = false;

			foreach (var item in productList)
			{
				if (item.Id.ToString() == productID)
				{
					flag = _productService.Delete(item);
					break;
				}
			}

			if (flag)
			{
				MessageBox.Show("Product deleted successfully", "Message", MessageBoxButtons.OK);
			}
			else
			{
				MessageBox.Show("No matching ProductId found", "Message", MessageBoxButtons.OK);
			}

			var productListWithCategory = _productService.GetAll()
				.Include(p => p.Category)
				.Select(p => new
				{
					p.Id,
					p.ProductCode,
					p.ProductName,
					p.Price,
					p.DateCreate,
					Category = p.Category.CategoryName
				})
				.ToList();

			dgvProductList.DataSource = new BindingSource()
			{
				DataSource = productListWithCategory
			};
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int productId = int.Parse(txtProductId.Text.Trim());
			string productCode = txtProductCode.Text.Trim().ToUpper();
			string productName = txtProductName.Text.Trim();
			decimal price;
			bool isValidPrice = decimal.TryParse(txtPrice.Text.Trim(), out price);
			string categoryName = cbCategory.Text.Trim();

			var productListCheck = _productService.GetAll().ToList();
			bool flag = false;
			// Check if all fields are valid
			if (!string.IsNullOrEmpty(productCode)
				&& productCode.Length == 4
				&& productCode.All(char.IsUpper)
				&& !string.IsNullOrEmpty(productName)
				&& isValidPrice
				&& price > 0
				&& !string.IsNullOrEmpty(categoryName))
			{
				var selectedCategory = _categoryService.GetAll().FirstOrDefault(c => c.CategoryName == categoryName);
				if (selectedCategory != null)
				{
					var product = productListCheck.FirstOrDefault(p => p.Id == productId);
					if (product != null)
					{
						product.ProductCode = productCode;
						product.ProductName = productName;
						product.Price = price;
						product.CategoryId = selectedCategory.Id;
						_productService.Update(product);
						flag = true;
					}
				}
				else
				{
					MessageBox.Show("Invalid category", "Message", MessageBoxButtons.OK);
				}
			}
			else
			{
				MessageBox.Show("Invalid input", "Message", MessageBoxButtons.OK);
			}

			if (!flag)
			{
				MessageBox.Show("Product ID not found", "Message", MessageBoxButtons.OK);
			}

			var productList = _productService.GetAll().Where(p => p.ProductCode.Contains(productCode)).Include(p => p.Category).Select(p => new
			{
				p.Id,
				p.ProductCode,
				p.ProductName,
				p.Price,
				p.DateCreate,
				Category = p.Category.CategoryName
			}).ToList();

			dgvProductList.DataSource = new BindingSource()
			{
				DataSource = productList
			};

			// Reset the input fields
			txtProductId.Text = "";
			txtProductCode.Text = "";
			txtSearch.Text = "";
			txtProductName.Text = "";
			txtPrice.Text = "";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string productCode = txtProductCode.Text.Trim().ToUpper();
			string productName = txtProductName.Text.Trim();
			decimal price;
			bool isValidPrice = decimal.TryParse(txtPrice.Text.Trim(), out price);
			string categoryName = cbCategory.Text.Trim();

			// Check if all fields are valid
			if (!string.IsNullOrEmpty(productCode)
				&& productCode.Length == 4
				&& productCode.All(char.IsUpper)
				&& !string.IsNullOrEmpty(productName)
				&& isValidPrice
				&& price > 0
				&& !string.IsNullOrEmpty(categoryName))
			{
				// Retrieve the selected category
				var selectedCategory = _categoryService.GetAll().FirstOrDefault(c => c.CategoryName == categoryName);
				if (selectedCategory != null)
				{
					// Create a new product
					var newProduct = new Product
					{
						ProductCode = productCode,
						ProductName = productName,
						Price = price,
						DateCreate = DateTime.Now,
						CategoryId = selectedCategory.Id
					};

					_productService.Create(newProduct);

					// Update the product list
					var productListWithCategory = _productService.GetAll()
						.Include(p => p.Category)
						.Select(p => new
						{
							p.Id,
							p.ProductCode,
							p.ProductName,
							p.Price,
							p.DateCreate,
							Category = p.Category.CategoryName
						})
						.ToList();

					dgvProductList.DataSource = new BindingSource()
					{
						DataSource = productListWithCategory
					};

					// Reset the input fields
					txtProductId.Text = "";
					txtProductCode.Text = "";
					txtSearch.Text = "";
					txtProductName.Text = "";
					txtPrice.Text = "";

					MessageBox.Show("Product added successfully", "Message", MessageBoxButtons.OK);
				}
				else
				{
					MessageBox.Show("Invalid category", "Message", MessageBoxButtons.OK);
				}
			}
			else
			{
				MessageBox.Show("Invalid input", "Message", MessageBoxButtons.OK);
			}
		}

		private void dgvProductList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{

		}
	}
}
