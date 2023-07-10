using Microsoft.Data.SqlClient;
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
        private string _user;
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
        public ProductManagement(string user) : this()
        {
            _user = user;
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
                MessageBox.Show("Thêm sản phẩm " + products.Name + " thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo");
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
                MessageBox.Show("Câp nhật sản phẩm thành công", "Thông báo");

            }
            catch
            {

                MessageBox.Show("Cập nhật sản phẩm thất bại", "Thông báo");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = txt_id.Text;
                var product = _db.TblProducts.Find(id);
                var result = MessageBox.Show("Bạn cắc muốn xóa sản phẩm: " + product.Name, "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _db.TblProducts.Remove(product);
                    _db.SaveChanges();
                    dataGridViewProduct.DataSource = _db.TblProducts.ToList();
                    MessageBox.Show("Sản phẩm " + product.Name + " đã được xóa", "Thông báo");
                }


            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
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
                txt_id.Enabled = false;
                btn_detail.Enabled = true;
            }

            catch
            {
                MessageBox.Show("Thao tác quá nhanh", "Thông báo");
            }

        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            try
            {
                var id = txt_id.Text;
                var product = _db.TblProducts.Find(id);
                MessageBox.Show(product.Description, product.Name);
            }
            catch
            {
                MessageBox.Show("Chọn sản phẩm để xem", "Thông báo");
            }

        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            try
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
                txt_id.Enabled = true;
                btn_detail.Enabled = false;


            }
            catch
            {
                MessageBox.Show("Thử lại", "Thông báo");
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
                                                    where product.Status == false && product.Name.Contains(searchKeyword)
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

            string productname = txt_name.Text;
            if (productname != null && productname != "")
            {
                string producttype = "details";
                Form form = new ProductManagementDetail(productname, producttype);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string sortOption = comboBox1.SelectedItem?.ToString() ?? "";
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

        private Form currentChildForm;

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; //lắp đầy panel chứa nó
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm; //truyền dl form đến panel
            childForm.BringToFront(); //mang form lên lớp trên cùng
            childForm.Show();         //và show
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            btnOrder.BackColor = SystemColors.ActiveCaptionText;
            btnBlog.BackColor = SystemColors.ActiveCaptionText;
            btnFeedback.BackColor = SystemColors.ActiveCaptionText;

            btnProduct.BackColor = Color.Chocolate;
            txtTitle.Text = "Quản lý Sản Phẩm";
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new OrderManagement());
            btnProduct.BackColor = SystemColors.ActiveCaptionText;
            btnBlog.BackColor = SystemColors.ActiveCaptionText;
            btnFeedback.BackColor = SystemColors.ActiveCaptionText;


            btnOrder.BackColor = Color.Chocolate;
            txtTitle.Text = "Quản lý Đơn Hàng";
        }

        private void btnBlog_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new BlogManagement());
            btnProduct.BackColor = SystemColors.ActiveCaptionText;
            btnOrder.BackColor = SystemColors.ActiveCaptionText;
            btnFeedback.BackColor = SystemColors.ActiveCaptionText;

            btnBlog.BackColor = Color.Chocolate;
            txtTitle.Text = "Quản lý Blog";
        }

        private void btnFeedback_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FeedbackManagement());
            btnProduct.BackColor = SystemColors.ActiveCaptionText;
            btnOrder.BackColor = SystemColors.ActiveCaptionText;
            btnBlog.BackColor = SystemColors.ActiveCaptionText;

            btnFeedback.BackColor = Color.Chocolate;
            txtTitle.Text = "Quản lý Đánh giá";
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            var check = _db.TblUsers.Where(p => p.Username == _user).First();
            if (check != null)
            {
                check.LastActivitty = DateTime.Now;
                _db.SaveChanges();
            }
            this.Hide();
            Form form = new Login();
            form.ShowDialog();
        }


    }
}
