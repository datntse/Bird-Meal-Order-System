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
            var orderId = dgvFeedbackList[0, e.RowIndex].Value;
            var order = _db.TblFeedbacks.Where(o => o.FeedbackId.Equals(orderId)).FirstOrDefault();
            if (order != null)
            {
                txt_id.Text = order.FeedbackId;
            }
        }

        private void txtdetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text == null)
                {
                    var fbId = txt_id.Text;
                    FeedbackDetails fbdetails = new FeedbackDetails(fbId);
                    fbdetails.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Khong Thanh Cong");
                }
            }
            catch
            {
                MessageBox.Show("Khong Thanh Cong");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
