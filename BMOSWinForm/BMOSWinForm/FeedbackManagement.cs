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
        }

        private void FeedbackManagement_Load(object sender, EventArgs e)
        {
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
                txtSearch.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btrs_Click(object sender, EventArgs e)
        {
            getlist();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("are you sure", "Confirm", MessageBoxButtons.YesNo);
                var index = _db.TblFeedbacks.Where(i => i.FeedbackId == txt_id.Text).FirstOrDefault();
                _db.TblFeedbacks.Remove(index);
                _db.SaveChanges();
                getlist();
                MessageBox.Show("Thanh Cong");
            }
            catch
            {
                MessageBox.Show("Khong Thanh Cong");
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
                Form form = new FeedbackDetails(id, type);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
