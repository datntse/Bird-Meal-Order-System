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
    public partial class Management : Form
    {
        private string _user;
        BMOSContext _db;
        public Management()
        {
            InitializeComponent();
            _db = new BMOSContext();
        }

        public Management(string user) : this()
        {
            _user = user;
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

        private void btnLogout_Click(object sender, EventArgs e)
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

        private void btnAcc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountManagement());
            btnHome.BackColor = SystemColors.ActiveCaptionText;

            btnAcc.BackColor = Color.Chocolate;
            txtTitle.Text = "Quản lý Tài Khoản";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            btnAcc.BackColor = SystemColors.ActiveCaptionText;

            btnHome.BackColor = Color.Chocolate;
            txtTitle.Text = "Dashboard";
        }
    }
}
