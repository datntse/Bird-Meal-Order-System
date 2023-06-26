using Microsoft.VisualBasic.ApplicationServices;
using Repository.Models.Entities;
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

namespace BMOSWinForm
{
    public partial class BlogDetail : Form
    {
        private string _blogname;
        private string _blogtype;
        BMOSContext _db;
        TblBlogServices _blogServices;
        TblBlog _blog;
        public BlogDetail()
        {
            InitializeComponent();
            _db = new BMOSContext();
            _blogServices = new TblBlogServices();
            _blog = new TblBlog();
        }
        public BlogDetail(string blogname, string blogtype) : this()
        {
            _blogname = blogname;
            _blogtype = blogtype;
            if (_blogtype.Equals("details"))
            {
                txtId.Text = _db.TblBlogs.Where(p => p.Name.Equals(_blogname)).Select(p => p.BlogId).First();
                txtName.Text = _blogname;
                txtDesc.Text = _db.TblBlogs.Where(p => p.Name.Equals(_blogname)).Select(p => p.Description).First();
                txtDate.Text = _db.TblBlogs.Where(p => p.Name.Equals(_blogname)).Select(p => p.Date).First().ToString();
                cbStatus.Text = _db.TblBlogs.Where(p => p.Name.Equals(_blogname)).Select(p => p.Status).First().ToString();
                lbBlogName.Text = _blogname;
                bool status = (bool)_db.TblBlogs.Where(p => p.Name.Equals(_blogname)).Select(p => p.Status).First();
                if (status)
                {
                    cbStatus.Text = "Hoạt động";
                }
                else
                {
                    cbStatus.Text = "Không hoạt động";
                }
                cbStatus.Enabled = false;
                txtDesc.Enabled = true;
                txtId.Enabled = false;
                txtName.Enabled = false;
                txtDate.Enabled = false;

            }
        }


        private void btnThoát(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BlogDetail_Load(object sender, EventArgs e)
        {

        }
    }


}

