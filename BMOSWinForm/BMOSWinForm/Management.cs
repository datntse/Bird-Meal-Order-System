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
using ZedGraph;

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
            button1.Enabled = false;
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


        public int getTotalProduct( int month)
        {
            int totalQuantity = _db.TblOrderDetails
                                    .Where(o => o.Date.HasValue && o.Date.Value.Month == 01)
                                    .Sum(o => o.Quantity ?? 0);

            return totalQuantity;
        }
        public void getTotalPrice()
        {
            double totalPrice = _db.TblOrders
                                    .Where(o => o.Date.HasValue && o.Date.Value.Month == 1)
                                    .Sum(o => o.TotalPrice.GetValueOrDefault());


            
        }
        public double GetTotalPriceOfOrdersInMonth(int month)
        {
            double totalPrice = _db.TblOrders
                                    .Where(o => o.Date.HasValue && o.Date.Value.Month == month)
                                    .Sum(o => o.TotalPrice.GetValueOrDefault());
            return totalPrice;
        }
        public void DrawChart()
        {
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Tổng giá trị đơn hàng theo tháng";

            myPane.XAxis.Title.Text = "";
            myPane.YAxis.Title.Text = "Tổng giá trị đơn hàng ($)";

            PointPairList list = new PointPairList();

            for (int i = 1; i <= 12; i++)
            {
                double total = GetTotalPriceOfOrdersInMonth(i);
                list.Add(i, total);
            }
            LineItem curve = myPane.AddCurve("", list, Color.Blue, SymbolType.None);
            BarItem bar = myPane.AddBar("Tổng giá trị đơn hàng", list, Color.Chocolate);

            zedGraphControl1.IsEnableZoom = false;
            zedGraphControl1.IsEnableVZoom = false;
            zedGraphControl1.IsEnableHZoom = false;
            zedGraphControl1.IsEnableWheelZoom = false;
            zedGraphControl1.IsEnableSelection = true;


            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            DrawChart();
        }
    }
}
