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

namespace BMOSWinForm
{
    public partial class FeedbackDetails : Form
    {
        BMOSContext _context;
        private string _fbId;
        private string _type;
        public FeedbackDetails(string fbid, string type)
        {
            _type = type;
            _fbId = fbid;
            _context = new BMOSContext();
            InitializeComponent();
            if (_type.Equals("details"))
            {
                txtidfb.Text = _context.TblFeedbacks.Where(p => p.FeedbackId.Equals(_fbId)).Select(p => p.FeedbackId).First();
                txtidsp.Text = _context.TblFeedbacks.Where(p => p.FeedbackId.Equals(_fbId)).Select(p => p.ProductId).First();
                txtname.Text = _context.TblFeedbacks.Where(p => p.FeedbackId.Equals(_fbId)).Select(p => p.Product.Name).First();
                txtcontent.Text = _context.TblFeedbacks.Where(p => p.FeedbackId.Equals(_fbId)).Select(p => p.Content).First();
                txtstar.Text = _context.TblFeedbacks.Where(p => p.FeedbackId.Equals(_fbId)).Select(p => p.Star).First().ToString() + "/5";
                txtdate.Text = _context.TblFeedbacks.Where(p => p.FeedbackId.Equals(_fbId)).Select(p => p.Date).First().ToString();

                txtidfb.Enabled = false;
                txtidsp.Enabled = false;
                txtname.Enabled = false;
                txtcontent.Enabled = false;
                txtstar.Enabled = false;
                txtdate.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Bạn có chắn chắc muốn xóa đánh giá này!!", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var index = _context.TblFeedbacks.Where(i => i.FeedbackId == txtidfb.Text).FirstOrDefault();
                    _context.TblFeedbacks.Remove(index);
                    _context.SaveChanges();

                    MessageBox.Show("Xóa thành công");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
