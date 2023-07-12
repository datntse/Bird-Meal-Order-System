using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMOSWinForm
{
    public partial class BlogManagement : Form
    {


        BMOSContext _db;
        public BlogManagement()
        {
            InitializeComponent();
            _db = new BMOSContext();
        }

        private void BlogManagement_Load(object sender, EventArgs e)
        {
            dgvBlog.DataSource = _db.TblBlogs.ToList();
            txtId.Enabled = false;
        }

        private void button_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Detail(object sender, EventArgs e)
        {
            string blogname = txtName.Text;
            if (blogname != null && blogname != "")
            {
                string blogtype = "details";
                Form form = new BlogDetail(blogname, blogtype);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn blog để thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void button_Delete(object sender, EventArgs e)
        {
            try
            {

                var result = MessageBox.Show("Bạn có chắc chắc muốn xóa blog này?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var id = txtId.Text;
                    var blogs = _db.TblBlogs.Find(id);
                    _db.TblBlogs.Remove(blogs);
                    _db.SaveChanges();
                    dgvBlog.DataSource = _db.TblBlogs.ToList();
                    MessageBox.Show("Xóa blog thành công!", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn blog để xóa!", "Thông báo");
            }
        }

        private void button_Edit(object sender, EventArgs e)
        {
            try
            {

                var blog = _db.TblBlogs.Find(txtId.Text);
                blog.Name = txtName.Text;
                blog.Description = txtDesc.Text;
                blog.Status = cbStatus.Checked;
                blog.Date = DateTime.Parse(txtDate.Text);
                _db.SaveChanges();
                dgvBlog.DataSource = _db.TblBlogs.ToList();
                MessageBox.Show("Chỉnh sửa blog thành công!", "Thông báo");

            }
            catch
            {
                MessageBox.Show("Vui lòng chọn blog để chỉnh sửa hoặc kiểm tra lại thông tin đã nhập!", "Thông báo");
            }
        }

        private void button_Add(object sender, EventArgs e)
        {
            try
            {

                if (
                    txtId.Text.Length > 0 &&
                    txtDate.Text.Length > 0 &&
                    txtDesc.Text.Length > 0 &&
                    txtName.Text.Length > 0)
                {

                    var blogs = new TblBlog
                    {
                        BlogId = txtId.Text,
                        Name = txtName.Text,
                        Description = txtDesc.Text,
                        Date = DateTime.Parse(txtDate.Text),
                        Status = cbStatus.Checked,

                    };
                    _db.TblBlogs.Add(blogs);
                    _db.SaveChanges();
                    dgvBlog.DataSource = _db.TblBlogs.ToList();
                    MessageBox.Show("Thêm blog thành công!", "Thông báo");
                }
                else { MessageBox.Show("Vui lòng điền dữ liệu!", "Thông báo"); }
            }
            catch
            {
                MessageBox.Show("Thêm blog thất bại, hãy kiểm tra lại dữ liệu bạn nhập vào!", "Thông báo");
            }
        }


        private void button_Search(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                var result = from blog in _db.TblBlogs
                             where blog.Name.Contains(searchKeyword)
                             select new
                             {
                                 BlogId = blog.BlogId,
                                 Name = blog.Name,
                                 Description = blog.Description,
                                 Date = blog.Date,
                                 Status = blog.Status
                             };
                dgvBlog.DataSource = new BindingSource { DataSource = result.ToList() };
            }
        }

        private void button_Clear(object sender, EventArgs e)
        {
            dgvBlog.DataSource = _db.TblBlogs.ToList();
            txtId.Text = null;
            txtName.Text = null;
            cbStatus.Checked = false;
            txtDate.Text = null;
            txtDesc.Text = null;
            txtId.Enabled = true;
            btnAdd.Enabled = true;
            txtSearch.Text = null;
            cbbSort.SelectedIndex = 0;
            txtDate.Enabled = true;
        }


        private void dgvBlog_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtDate.Enabled = false;
                btnAdd.Enabled = false;
                txtId.Enabled = false;
                var id = dgvBlog.Rows[e.RowIndex].Cells[0].Value.ToString();
                var blog = _db.TblBlogs.Find(id);
                txtId.Text = blog.BlogId;
                txtName.Text = blog.Name;
                txtDate.Text = blog.Date.ToString();
                cbStatus.Checked = blog.Status.ToString() == "True";
                txtDesc.Text = blog.Description;
            }

            catch
            {
                MessageBox.Show("Thao tác quá nhanh vui lòng thử lại!", "Thông báo");
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                var result = from blog in _db.TblBlogs
                             where blog.Name.Contains(searchKeyword)
                             select new
                             {
                                 BlogId = blog.BlogId,
                                 Name = blog.Name,
                                 Description = blog.Description,
                                 Date = blog.Date,
                                 Status = blog.Status
                             };
                dgvBlog.DataSource = new BindingSource { DataSource = result.ToList() };
            }
        }

        private void ccbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();
            string sortOption = cbbSort.SelectedItem?.ToString() ?? "";
            if (!string.IsNullOrEmpty(sortOption))
            {
                switch (sortOption)
                {
                    case "Blog hoạt động":
                        var statusTrueResult = from blog in _db.TblBlogs
                                               where blog.Status == true && blog.Name.Contains(searchKeyword)
                                               orderby blog.BlogId ascending
                                               select new
                                               {
                                                   BlogId = blog.BlogId,
                                                   Name = blog.Name,
                                                   Description = blog.Description,
                                                   Date = blog.Date,
                                                   Status = blog.Status
                                               };
                        dgvBlog.DataSource = statusTrueResult.ToList();
                        break;
                    case "Blog không hoạt động":
                        var statusFalseResult = from blog in _db.TblBlogs
                                                where blog.Status == false && blog.Name.Contains(searchKeyword)
                                                orderby blog.BlogId ascending
                                                select new
                                                {
                                                    BlogId = blog.BlogId,
                                                    Name = blog.Name,
                                                    Description = blog.Description,
                                                    Date = blog.Date,
                                                    Status = blog.Status
                                                };
                        dgvBlog.DataSource = statusFalseResult.ToList();
                        break;
                    case "Tất cả":
                        var statusAllResult = from blog in _db.TblBlogs
                                              select new
                                              {
                                                  BlogId = blog.BlogId,
                                                  Name = blog.Name,
                                                  Description = blog.Description,
                                                  Date = blog.Date,
                                                  Status = blog.Status
                                              };
                        dgvBlog.DataSource = statusAllResult.ToList();
                        break;
                    case "Từ A đến Z":
                        var statusFromAtoZResult = from blog in _db.TblBlogs
                                                   where blog.Name.Contains(searchKeyword)
                                                   orderby blog.Name ascending
                                                   select new
                                                   {
                                                       BlogId = blog.BlogId,
                                                       Name = blog.Name,
                                                       Description = blog.Description,
                                                       Date = blog.Date,
                                                       Status = blog.Status
                                                   };
                        dgvBlog.DataSource = statusFromAtoZResult.ToList();
                        break;
                }
            }
        }

        private void Blog_format(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }

}