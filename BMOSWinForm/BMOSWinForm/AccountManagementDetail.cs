using Azure.Identity;
using Microsoft.VisualBasic.ApplicationServices;
using Repository.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        TblUser _user;
        public AccountManagementDetail()
        {
            InitializeComponent();
            _db = new BMOSContext();
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
                txtStatus.Text = "";
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
                txtStatus.Text = "";
                txtCre.Text = cre.ToString();
                txtLday.Text = "";
                txtPoint.Text = "0";


                txtFirst.Enabled = true;
                txtLast.Enabled = true;
                txtAddress.Enabled = true;
                txtPhone.Enabled = true;
                txtEmail.Enabled = true;
                txtPass.Enabled = true;

                txtRole.Enabled = false;
                txtCre.Enabled = false;
                txtLday.Enabled = false;
                txtPoint.Enabled = false;

                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnAddReal.Visible = true;
            }
        }

        private void btnAddReal_Click(object sender, EventArgs e)
        {          
            _user.Firstname = txtFirst.Text;
            _user.Lastname = txtLast.Text;
            _user.Address = txtAddress.Text;
            _user.Numberphone = txtPhone.Text;
            _user.Username = txtEmail.Text;
            _user.Password = txtPass.Text;
            _user.UserRoleId = 2;
            _user.Status = true;
            _user.DateCreate = DateTime.Now;
            _user.LastActivitty = DateTime.Now;
            _user.Point = 0;

            _db.TblUsers.Add(_user);
            _db.SaveChanges();
            
            this.Hide();
            Form form = new Management();
            form.ShowDialog();
        }
    }
}
