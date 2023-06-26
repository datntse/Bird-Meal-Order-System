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
        public Management()
        {
            InitializeComponent();
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
            this.Hide();
            Form form = new Login();
            form.ShowDialog();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountManagement());

            btnProduct.BackColor = SystemColors.ActiveCaptionText;
            btnOrder.BackColor = SystemColors.ActiveCaptionText;
            btnBlog.BackColor = SystemColors.ActiveCaptionText;
            btnFeedback.BackColor = SystemColors.ActiveCaptionText;
            btnHome.BackColor = SystemColors.ActiveCaptionText;

            btnAcc.BackColor = Color.Chocolate;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductManagement());
            btnAcc.BackColor = SystemColors.ActiveCaptionText;
            btnOrder.BackColor = SystemColors.ActiveCaptionText;
            btnBlog.BackColor = SystemColors.ActiveCaptionText;
            btnFeedback.BackColor = SystemColors.ActiveCaptionText;
            btnHome.BackColor = SystemColors.ActiveCaptionText;


            btnProduct.BackColor = Color.Chocolate;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrderManagement());
            btnAcc.BackColor = SystemColors.ActiveCaptionText;
            btnProduct.BackColor = SystemColors.ActiveCaptionText;
            btnBlog.BackColor = SystemColors.ActiveCaptionText;
            btnFeedback.BackColor = SystemColors.ActiveCaptionText;
            btnHome.BackColor = SystemColors.ActiveCaptionText;


            btnOrder.BackColor = Color.Chocolate;
        }

        private void btnBlog_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BlogManagement());
            btnAcc.BackColor = SystemColors.ActiveCaptionText;
            btnProduct.BackColor = SystemColors.ActiveCaptionText;
            btnOrder.BackColor = SystemColors.ActiveCaptionText;
            btnFeedback.BackColor = SystemColors.ActiveCaptionText;
            btnHome.BackColor = SystemColors.ActiveCaptionText;


            btnBlog.BackColor = Color.Chocolate;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FeedbackManagement());
            btnAcc.BackColor = SystemColors.ActiveCaptionText;
            btnProduct.BackColor = SystemColors.ActiveCaptionText;
            btnOrder.BackColor = SystemColors.ActiveCaptionText;
            btnBlog.BackColor = SystemColors.ActiveCaptionText;
            btnHome.BackColor = SystemColors.ActiveCaptionText;


            btnFeedback.BackColor = Color.Chocolate;
        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MessManagement());

            btnAcc.BackColor = SystemColors.ActiveCaptionText;
            btnProduct.BackColor = SystemColors.ActiveCaptionText;
            btnOrder.BackColor = SystemColors.ActiveCaptionText;
            btnBlog.BackColor = SystemColors.ActiveCaptionText;
            btnFeedback.BackColor = SystemColors.ActiveCaptionText;
            btnHome.BackColor = SystemColors.ActiveCaptionText;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            btnAcc.BackColor = SystemColors.ActiveCaptionText;
            btnProduct.BackColor = SystemColors.ActiveCaptionText;
            btnOrder.BackColor = SystemColors.ActiveCaptionText;
            btnBlog.BackColor = SystemColors.ActiveCaptionText;
            btnFeedback.BackColor = SystemColors.ActiveCaptionText;

            btnHome.BackColor = Color.Chocolate;
        }
    }
}
