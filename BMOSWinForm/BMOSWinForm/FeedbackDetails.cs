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
        public FeedbackDetails(string fbid)
        {
            _fbId = fbid;
            _context = new BMOSContext();
            InitializeComponent();
        }

        private void FeedbackDetails_Load(object sender, EventArgs e)
        {

            textBox1.Text = _fbId;
        }
    }
}
