using ElectricStore_Datnt.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStore_TramLU
{
	public partial class Management : Form
	{
		ProductService _productRepo = new ProductService();
		CategoryService _categoryRepo = new CategoryService();
		UserService _userRepo = new UserService();

		public Management()
		{
			InitializeComponent();

			txtProductId.Enabled = false;

			var categoryList = _categoryRepo.GetAll().ToList();
			var productList = _productRepo.GetAll().Include(p => p.Category).Select(p => new
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
				var producList = _productRepo.GetAll().Where(p => p.ProductCode.Contains(productCode)).Include(p => p.Category).Select(p => new
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

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			var productCode = "";
			var productList = _productRepo.GetAll().Where(p => p.ProductCode.Contains(productCode)).Include(p => p.Category).Select(p => new
			{
				p.Id,
				p.ProductCode,
				p.ProductName,
				p.Price,
				p.DateCreate,
				Category = p.Category.CategoryName
			}).ToList();
			dgvProductList.DataSource = productList;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var productList = _productRepo.GetAll().ToList();
			var productID = txtProductId.Text;
			bool flag = false;

			foreach (var item in productList)
			{
				if (item.Id.ToString() == productID)
				{
					flag = _productRepo.Delete(item);
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

			var productListWithCategory = _productRepo.GetAll()
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
			maintainSearch(sender, e);
		}

		private void maintainSearch(object sender, EventArgs e)
		{
			var productCode = txtSearch.Text.ToString();
			var producList = _productRepo.GetAll().Where(p => p.ProductCode.Contains(productCode)).Include(p => p.Category).Select(p => new
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

		private void dgvProductList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var _producList = _productRepo.GetAll();
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

				var selectedCategory = _categoryRepo.GetAll().FirstOrDefault(t => t.CategoryName == Category);
				txtProductId.Text = productId;
				txtProductCode.Text = productCode;
				txtProductName.Text = productName;
				txtPrice.Text = price;
			}
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
				var selectedCategory = _categoryRepo.GetAll().FirstOrDefault(c => c.CategoryName == categoryName);
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

					_productRepo.Create(newProduct);

					// Update the product list
					var productListWithCategory = _productRepo.GetAll()
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

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int productId = int.Parse(txtProductId.Text.Trim());
			string productCode = txtProductCode.Text.Trim().ToUpper();
			string productName = txtProductName.Text.Trim();
			decimal price;
			bool isValidPrice = decimal.TryParse(txtPrice.Text.Trim(), out price);
			string categoryName = cbCategory.Text.Trim();

			var productListCheck = _productRepo.GetAll().ToList();
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
				var selectedCategory = _categoryRepo.GetAll().FirstOrDefault(c => c.CategoryName == categoryName);
				if (selectedCategory != null)
				{
					var product = productListCheck.FirstOrDefault(p => p.Id == productId);
					if (product != null)
					{
						product.ProductCode = productCode;
						product.ProductName = productName;
						product.Price = price;
						product.CategoryId = selectedCategory.Id;
						_productRepo.Update(product);
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

			var productList = _productRepo.GetAll().Where(p => p.ProductCode.Contains(productCode)).Include(p => p.Category).Select(p => new
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
	}
}
