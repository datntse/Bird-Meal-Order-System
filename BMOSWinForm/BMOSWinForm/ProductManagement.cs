using Microsoft.Data.SqlClient;
using Repository.Models.Entities;
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
        public ProductManagement()
        {
            InitializeComponent();
            _db = new BMOSContext();

        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {

            dataGridViewProduct.DataSource = _db.TblProducts.ToList();

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

        private void btn_imgurl_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "JPEG|*.jpg" })
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pb_product.Image = Image.FromFile(dlg.FileName);
                    TblProduct obj = tblProductBindingSource.Current as TblProduct;
                    if (obj != null)
                    {
                        obj.ImagelInk = dlg.FileName;
                    }
                }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            pb_product.Image = null;
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

        }


    }
}
