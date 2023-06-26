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



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BlogManagement_Load(object sender, EventArgs e)
        {
            dgvBlog.DataSource = _db.TblBlogs.ToList();
            txtId.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Detail(object sender, EventArgs e)
        {
            try
            {
                var id = txtId.Text;
                var blog = _db.TblBlogs.Find(id);
                MessageBox.Show(blog.Description);
            }
            catch
            {
                MessageBox.Show("Chon Blog");
            }
        }

        private void button_Delete(object sender, EventArgs e)
        {
            try
            {

                var result = MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var id = txtId.Text;
                    var blogs = _db.TblBlogs.Find(id);
                    _db.TblBlogs.Remove(blogs);
                    _db.SaveChanges();
                    dgvBlog.DataSource = _db.TblBlogs.ToList();
                    MessageBox.Show("Xoa thanh Cong");
                }
            }
            catch
            {
                MessageBox.Show("Error");
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
                MessageBox.Show("Sua thanh Cong");

            }
            catch
            {
                MessageBox.Show("Sua khong Thanh Cong");
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
                    MessageBox.Show("Them thanh Cong");
                }
                else { MessageBox.Show("Please type in!"); }
            }
            catch
            {
                MessageBox.Show("Them khong thanh cong");
            }
        }


        private void button_Search(object sender, EventArgs e)
        {

        }


        private void dgvBlog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Clear(object sender, EventArgs e)
        {
            txtId.Text = null;
            txtName.Text = null;
            cbStatus.Checked = false;
            txtDate.Text = null;
            txtDesc.Text = null;
            txtId.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void dgvBlog_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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
                MessageBox.Show("Thao tac qua nhanh");
            }
        }
    }
}