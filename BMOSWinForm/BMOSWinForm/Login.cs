using Repository.Models.Entities;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMOSWinForm
{
    public partial class Login : Form
    {
        BMOSContext _db;

        public Login()
        {
            InitializeComponent();
            _db = new BMOSContext();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var check = _db.TblUsers.Where(p => p.Username.Equals(username) && p.Password.Equals(password)).Select(p => p.UserRoleId);
            if (check.Count() > 0)
            {
                var checkStatus = _db.TblUsers.Where(p => p.Username.Equals(username) && p.Status == true);
                var id = check.First();
                if (id == 1)
                {
                    this.Hide();
                    Form form = new Management(username);
                    form.ShowDialog();
                }
                else if (id == 2)
                {
                    if (checkStatus.Count() > 0)
                    {
                        this.Hide();
                        Form form = new ProductManagement(username);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản của bạn đã bị khóa.", "Thông báo", MessageBoxButtons.OK);
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản của bạn không được cấp quyền để thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }

            }
            else
            {
                //dang nhap that bai
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK);
                txtUsername.Text = "";
                txtPassword.Text = "";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
