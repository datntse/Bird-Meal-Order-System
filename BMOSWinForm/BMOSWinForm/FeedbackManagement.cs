using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repository.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMOSWinForm
{
    public partial class FeedbackManagement : Form
    {
        BMOSContext _db;
        public FeedbackManagement()
        {
            InitializeComponent();
            _db = new BMOSContext();
        }

        public void getlist()
        {
            var feedback = from f in _db.TblFeedbacks
                           select new
                           {
                               idfb = f.FeedbackId,
                               idpro = f.ProductId,
                               name = f.Product.Name,
                               content = f.Content,
                               star = f.Star,
                               date = f.Date,
                           };
            dgvFeedbackList.DataSource = feedback.ToList();
            dgvFeedbackList.DefaultCellStyle.SelectionBackColor = Color.Orange;
        }

        private void FeedbackManagement_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Tất cả sản phẩm";
            getlist();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var feedback = from f in _db.TblFeedbacks
                               select new
                               {
                                   idfb = f.FeedbackId,
                                   idpro = f.ProductId,
                                   name = f.Product.Name,
                                   content = f.Content,
                                   star = f.Star,
                                   date = f.Date,
                               };
                feedback = feedback.Where(x => x.name.Contains(txtSearch.Text));
                dgvFeedbackList.DataSource = feedback.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btrs_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            comboBox1.SelectedItem = "Tất cả sản phẩm";
            getlist();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txt_id.Text;
                if (id != null && id != "")
                {
                    var result = MessageBox.Show("Bạn có chắn chắc muốn xóa đánh giá này!!", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var index = _db.TblFeedbacks.Where(i => i.FeedbackId == txt_id.Text).FirstOrDefault();
                        _db.TblFeedbacks.Remove(index);
                        _db.SaveChanges();
                        getlist();
                        MessageBox.Show("Xóa thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng để thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dgvFeedbackList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Enabled = false;
            if (e.RowIndex == -1) return;
            int index = e.RowIndex;
            DataGridViewRow username = dgvFeedbackList.Rows[index];
            txt_id.Text = username.Cells[0].Value.ToString();
        }

        private void txtdetails_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            if (id != null && id != "")
            {
                string type = "details";
                txt_id.Text = "";
                FeedbackDetails form = new FeedbackDetails(id, type);
                form.ShowDialog();
                getlist();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();
            string sortOption = comboBox1.SelectedItem?.ToString() ?? "";
            if (!string.IsNullOrEmpty(sortOption))
            {
                switch (sortOption)
                {
                    case "A-Z":
                        var az = from f in _db.TblFeedbacks
                                 where f.Product.Name.Contains(searchKeyword)
                                 select new
                                 {
                                     idfb = f.FeedbackId,
                                     idpro = f.ProductId,
                                     name = f.Product.Name,
                                     content = f.Content,
                                     star = f.Star,
                                     date = f.Date,
                                 };
                        az = az.OrderBy(f => f.name);
                        dgvFeedbackList.DataSource = az.ToList();
                        break;
                    case "Z-A":
                        var za = from f in _db.TblFeedbacks
                                 where f.Product.Name.Contains(searchKeyword)
                                 select new
                                 {
                                     idfb = f.FeedbackId,
                                     idpro = f.ProductId,
                                     name = f.Product.Name,
                                     content = f.Content,
                                     star = f.Star,
                                     date = f.Date,
                                 };
                        za = za.OrderByDescending(f => f.name);
                        dgvFeedbackList.DataSource = za.ToList();
                        break;
                    case "Số sao giảm dần":
                        var stardes = from f in _db.TblFeedbacks
                                      where f.Product.Name.Contains(searchKeyword)
                                      select new
                                      {
                                          idfb = f.FeedbackId,
                                          idpro = f.ProductId,
                                          name = f.Product.Name,
                                          content = f.Content,
                                          star = f.Star,
                                          date = f.Date,
                                      };
                        stardes = stardes.OrderByDescending(f => f.star);
                        dgvFeedbackList.DataSource = stardes.ToList();
                        break;
                    case "Số sao tăng dần":
                        var starin = from f in _db.TblFeedbacks
                                     where f.Product.Name.Contains(searchKeyword)
                                     select new
                                     {
                                         idfb = f.FeedbackId,
                                         idpro = f.ProductId,
                                         name = f.Product.Name,
                                         content = f.Content,
                                         star = f.Star,
                                         date = f.Date,
                                     };
                        starin = starin.OrderBy(f => f.star);
                        dgvFeedbackList.DataSource = starin.ToList();
                        break;
                    default:
                        comboBox1.SelectedItem = "Tất cả sản phẩm";
                        getlist();
                        break;
                }
            }
        }
    }

}
