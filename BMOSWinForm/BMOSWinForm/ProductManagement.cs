﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repository.Models.Entities;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMOSWinForm
{
    public partial class ProductManagement : Form
    {
        BMOSContext _db;
        TblProductServices _productServices;
        public ProductManagement()
        {
            InitializeComponent();
            _db = new BMOSContext();
            _productServices = new TblProductServices();

            var list = _productServices.GetAll().Select(p => new
            {
                p.ProductId,
                p.Name,
                p.Quantity,
                p.Weight,
                p.Status,
                p.Price,
                p.Type,
                p.Description

            }).ToList();

            dataGridViewProduct.DataSource = list.ToList();

            dataGridViewProduct.Columns[0].HeaderText = "Mã Sản Phẩm";
            dataGridViewProduct.Columns[1].HeaderText = "Tên Sản Phâm";
            dataGridViewProduct.Columns[2].HeaderText = "Số Lượng";
            dataGridViewProduct.Columns[3].HeaderText = "Cân nặng";
            dataGridViewProduct.Columns[4].HeaderText = "Còn hàng";
            dataGridViewProduct.Columns[5].HeaderText = "Giá tiền";
            dataGridViewProduct.Columns[6].HeaderText = "Loại";
            dataGridViewProduct.Columns[7].HeaderText = "Thông tin";


            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewProduct.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewProduct.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewProduct.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewProduct.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewProduct.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewProduct.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {

            //dataGridViewProduct.DataSource = _db.TblProducts.ToList();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                var products = new TblProduct
                {

                    ProductId = txt_id.Text,
                    Name = txt_name.Text,
                    Description = txt_decription.Text,
                    Quantity = int.Parse(txt_quantity.Text),
                    Price = float.Parse(txt_price.Text),
                    Weight = int.Parse(txt_weight.Text),
                    Type = txt_type.Text,
                    Status = checkBox_status.Checked,

                };
                _db.TblProducts.Add(products);
                _db.SaveChanges();
                dataGridViewProduct.DataSource = _db.TblProducts.ToList();
                MessageBox.Show("Thanh Cong");
            }
            catch
            {
                MessageBox.Show("Khong Thanh Cong");
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                var product = _db.TblProducts.Find(txt_id.Text);
                product.Name = txt_name.Text;
                product.Description = txt_decription.Text;
                product.Price = float.Parse(txt_price.Text);
                product.Weight = int.Parse(txt_weight.Text);
                product.Type = txt_type.Text;
                product.Quantity = int.Parse(txt_quantity.Text);
                product.Status = checkBox_status.Checked;
                _db.SaveChanges();
                dataGridViewProduct.DataSource = _db.TblProducts.ToList();
                MessageBox.Show("Thanh Cong");

            }
            catch
            {
                MessageBox.Show("Khong Thanh Cong");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("are you sure", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var id = txt_id.Text;
                    var product = _db.TblProducts.Find(id);
                    _db.TblProducts.Remove(product);
                    _db.SaveChanges();
                    dataGridViewProduct.DataSource = _db.TblProducts.ToList();
                    MessageBox.Show("Thanh Cong");
                }


            }
            catch
            {
                MessageBox.Show("Khong Thanh Cong");
            }
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                var product = _db.TblProducts.Find(id);
                txt_id.Text = product.ProductId;
                txt_name.Text = product.Name;
                txt_quantity.Text = product.Quantity.ToString();
                txt_decription.Text = product.Description;
                txt_weight.Text = product.Weight.ToString();
                txt_type.Text = product.Type.ToString();
                txt_price.Text = product.Price.ToString();
                checkBox_status.Checked = product.Status.ToString() == "True";
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
            }

            catch
            {
                MessageBox.Show("Thao tac qua nhanh");
            }

        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            try
            {
                var id = txt_id.Text;
                var product = _db.TblProducts.Find(id);
                MessageBox.Show(product.Description);
            }
            catch
            {
                MessageBox.Show("Chon San Pham");
            }

        }



        private void btn_add_Click(object sender, EventArgs e)
        {

            txt_id.Text = null;
            txt_price.Text = null;
            txt_decription.Text = null;
            txt_name.Text = null;
            txt_type.Text = null;
            txt_weight.Text = null;
            txt_quantity.Text = null;
            checkBox_status.Checked = false;
            txt_id.Focus();
            tblProductBindingSource.MoveLast();
        }
        public void Search()
        {

        }
        private void btn_search_Click(object sender, EventArgs e)
        {

            string searchKeyword = txt_search.Text.Trim();
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                var result = from product in _db.TblProducts
                             where product.Name.Contains(searchKeyword)
                             select new
                             {
                                 ProductID = product.ProductId,
                                 Name = product.Name,
                                 Price = product.Price,
                                 Quantity = product.Quantity,
                                 Type = product.Type,
                                 Weight = product.Weight,
                                 Status = product.Status,
                                 Description = product.Description 
                             };
                dataGridViewProduct.DataSource = new BindingSource { DataSource = result.ToList() };
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string searchKeyword = txt_search.Text.Trim();
                string sortOption = comboBox1.SelectedItem?.ToString() ?? "";
                if (!string.IsNullOrEmpty(sortOption))
                {
                    switch (sortOption)
                    {
                        case "Sản phẩm còn hàng":
                            var statusTrueResult = from product in _db.TblProducts
                                                   where product.Status == true && product.Name.Contains(searchKeyword)
                                                   orderby product.Name ascending
                                                   select new
                                                   {
                                                       ProductID = product.ProductId,
                                                       Name = product.Name,
                                                       Price = product.Price,
                                                       Quantity = product.Quantity,
                                                       Type = product.Type,
                                                       Weight = product.Weight,
                                                       Status = product.Status,
                                                       Description = product.Description
                                                   };
                            dataGridViewProduct.DataSource = statusTrueResult.ToList();
                            break;
                        case "Tất cả sản phẩm":
                            var AllProduct = from product in _db.TblProducts
                                             where product.Name.Contains(searchKeyword)
                                             orderby product.ProductId ascending
                                             select new
                                             {
                                                 ProductID = product.ProductId,
                                                 Name = product.Name,
                                                 Price = product.Price,
                                                 Quantity = product.Quantity,
                                                 Type = product.Type,
                                                 Weight = product.Weight,
                                                 Status = product.Status,
                                                 Description = product.Description

                                             };
                            dataGridViewProduct.DataSource = AllProduct.ToList();
                            break;
                        case "A-Z":
                            var AZ = from product in _db.TblProducts
                                     where product.Name.Contains(searchKeyword)
                                     orderby product.Name ascending
                                     select new
                                     {
                                         ProductID = product.ProductId,
                                         Name = product.Name,
                                         Price = product.Price,
                                         Quantity = product.Quantity,
                                         Type = product.Type,
                                         Weight = product.Weight,
                                         Status = product.Status,
                                         Description = product.Description
                                     };
                            dataGridViewProduct.DataSource = AZ.ToList();
                            break;
                        case "Sản phẩm hết hàng":
                            var statusFalseResult = from product in _db.TblProducts
                                                    where product.Status == false &&  product.Name.Contains(searchKeyword)
                                                    orderby product.Name ascending
                                                    select new
                                                    {
                                                        ProductID = product.ProductId,
                                                        Name = product.Name,
                                                        Price = product.Price,
                                                        Quantity = product.Quantity,
                                                        Type = product.Type,
                                                        Weight = product.Weight,
                                                        Status = product.Status,
                                                        Description = product.Description
                                                    };
                            dataGridViewProduct.DataSource = statusFalseResult.ToList();
                            break;
                        case "Thức ăn hạt":
                            var type1Result = from product in _db.TblProducts
                                              where product.Type == "1" && product.Name.Contains(searchKeyword)
                                              orderby product.ProductId ascending
                                              select new
                                              {
                                                  ProductID = product.ProductId,
                                                  Name = product.Name,
                                                  Price = product.Price,
                                                  Quantity = product.Quantity,
                                                  Type = product.Type,
                                                  Weight = product.Weight,
                                                  Status = product.Status,
                                                  Description = product.Description
                                              };
                            dataGridViewProduct.DataSource = type1Result.ToList();
                            break;
                        case "Thức ăn tự nhiên":
                            var type2Result = from product in _db.TblProducts
                                              where product.Type == "2" && product.Name.Contains(searchKeyword)
                                              orderby product.ProductId ascending
                                              select new
                                              {
                                                  ProductID = product.ProductId,
                                                  Name = product.Name,
                                                  Price = product.Price,
                                                  Quantity = product.Quantity,
                                                  Type = product.Type,
                                                  Weight = product.Weight,
                                                  Status = product.Status,
                                                  Description = product.Description
                                              };
                            dataGridViewProduct.DataSource = type2Result.ToList();
                            break;
                        case "Thức ăn hỗn hợp":
                            var type3Result = from product in _db.TblProducts
                                              where product.Type == "3" && product.Name.Contains(searchKeyword)
                                              orderby product.ProductId ascending
                                              select new
                                              {
                                                  ProductID = product.ProductId,
                                                  Name = product.Name,
                                                  Price = product.Price,
                                                  Quantity = product.Quantity,
                                                  Type = product.Type,
                                                  Weight = product.Weight,
                                                  Status = product.Status,
                                                  Description = product.Description
                                              };
                            dataGridViewProduct.DataSource = type3Result.ToList();
                            break;
                    }
                }
            }
        }

        private void btn_viewproduct_Click(object sender, EventArgs e)
        {





            Form productForm = new Form();
            productForm.Text = "Product Details";



            productForm.ShowDialog();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txt_search.Text.Trim();
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                var result = from product in _db.TblProducts
                             where product.Name.Contains(searchKeyword)
                             select new
                             {
                                 ProductID = product.ProductId,
                                 Name = product.Name,
                                 Price = product.Price,
                                 Quantity = product.Quantity,
                                 Type = product.Type,
                                 Weight = product.Weight,
                                 Status = product.Status,
                                 Description = product.Description
                             };
                dataGridViewProduct.DataSource = new BindingSource { DataSource = result.ToList() };
            }
            //else
            //{
            //    dataGridViewProduct.DataSource = _db.TblProducts.ToList();

            //}
        }
    }
}