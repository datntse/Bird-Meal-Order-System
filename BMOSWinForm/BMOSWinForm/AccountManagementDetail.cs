using Azure.Identity;
using Microsoft.VisualBasic.ApplicationServices;
using Repository.Models.Entities;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMOSWinForm
{
    public partial class AccountManagementDetail : Form
    {
        private string _username;
        private string _type;
        BMOSContext _db;
        TblUserServices _userServices;
        TblUser _user;
        public AccountManagementDetail()
        {
            InitializeComponent();
            _db = new BMOSContext();
            _userServices = new TblUserServices();
            _user = new TblUser();
        }

        public AccountManagementDetail(string user, string type) : this()
        {
            _username = user;
            _type = type;

            if (_type.Equals("details"))
            {
                txtFirst.Text = _db.TblUsers.Where(p => p.Username.Equals(_username)).Select(p => p.Firstname).First();
                txtLast.Text = _db.TblUsers.Where(p => p.Username.Equals(_username)).Select(p => p.Lastname).First();
                txtAddress.Text = _db.TblUsers.Where(p => p.Username.Equals(_username)).Select(p => p.Address).First();
                txtPhone.Text = _db.TblUsers.Where(p => p.Username.Equals(_username)).Select(p => p.Numberphone).First();
                txtEmail.Text = _username;
                txtPass.Text = _db.TblUsers.Where(p => p.Username.Equals(_username)).Select(p => p.Password).First();

                int role = (int)_db.TblUsers.Where(p => p.Username.Equals(_username)).Select(p => p.UserRoleId).First();
                if (role == 1)
                {
                    txtRole.Text = "Admin";
                }
                else if (role == 2)
                {
                    txtRole.Text = "Nhân viên";
                }
                else
                {
                    txtRole.Text = "Khách hàng";
                }

                bool status = (bool)_db.TblUsers.Where(p => p.Username.Equals(_username)).Select(p => p.Status).First();
                if (status)
                {
                    txtStatus.Text = "Hoạt động";
                }
                else
                {
                    txtStatus.Text = "Vô hiệu hóa";
                }

                txtCre.Text = _db.TblUsers.Where(p => p.Username.Equals(_username)).Select(p => p.DateCreate).First().ToString();
                txtLday.Text = _db.TblUsers.Where(p => p.Username.Equals(_username)).Select(p => p.LastActivitty).First().ToString();
                txtPoint.Text = _db.TblUsers.Where(p => p.Username.Equals(_username)).Select(p => p.Point).First().ToString();
            }
            else
            {
                DateTime cre = DateTime.Now;

                txtFirst.Text = null;
                txtLast.Text = null;
                txtAddress.Text = null;
                txtPhone.Text = null;
                txtEmail.Text = null;
                txtPass.Text = null;
                txtRole.Text = "Nhân viên";
                txtStatus.Text = "Hoạt động";
                txtCre.Text = cre.ToString();
                txtLday.Text = "";
                txtPoint.Text = "0";

                txtFirst.Enabled = true;
                txtLast.Enabled = true;
                txtAddress.Enabled = true;
                txtPhone.Enabled = true;
                txtEmail.Enabled = true;
                txtPass.Enabled = true;

                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnAddReal.Visible = true;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string username = txtEmail.Text;
            string status = txtStatus.Text;
            bool sta;
            if (status.Equals("Hoạt động"))
            {
                sta = true;
            }
            else
            {
                sta = false;
            }

            var update = _db.TblUsers.FirstOrDefault(p => p.Username.Equals(username));
            if (update != null)
            {
                update.Status = sta;
                _db.SaveChanges();

                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại, vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_username != null)
            {
                DateTime cre = DateTime.Now;

                txtFirst.Text = null;
                txtLast.Text = null;
                txtAddress.Text = null;
                txtPhone.Text = null;
                txtEmail.Text = null;
                txtPass.Text = null;
                txtRole.Text = "Nhân viên";
                txtStatus.Text = "Hoạt động";
                txtCre.Text = cre.ToString();
                txtLday.Text = "";
                txtPoint.Text = "0";

                txtFirst.Enabled = true;
                txtLast.Enabled = true;
                txtAddress.Enabled = true;
                txtPhone.Enabled = true;
                txtEmail.Enabled = true;
                txtPass.Enabled = true;

                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnAddReal.Visible = true;
            }
        }

        private void btnAddReal_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text != "" && txtLast.Text != "" && txtAddress.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && txtPass.Text != "" && txtFirst.Text != null && txtLast.Text != null && txtAddress.Text != null && txtPhone.Text != null && txtEmail.Text != null && txtPass.Text != null)
            {
                string username = txtEmail.Text;
                var check = _db.TblUsers.Where(p => p.Username == username).FirstOrDefault();
                if (check == null)
                {
                    _user.Username = txtEmail.Text;
                    _user.Firstname = txtFirst.Text;
                    _user.Lastname = txtLast.Text;
                    _user.Address = txtAddress.Text;
                    _user.Numberphone = txtPhone.Text;
                    if (txtStatus.Text.Equals("Hoạt động"))
                    {
                        _user.Status = true;
                    }
                    else
                    {
                        _user.Status = false;
                    }
                    _user.Password = txtPass.Text;

                    _db.TblUsers.Add(_user);
                    _db.SaveChanges();

                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email đã tồn tại, vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
