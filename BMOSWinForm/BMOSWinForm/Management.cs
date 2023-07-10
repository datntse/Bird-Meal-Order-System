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
using Dashboard;
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
            // Khởi tạo biểu đồ
            GraphPane myPane = zedGraphControl1.GraphPane;

            //// Đặt tên cho trục X và trục Y
            //myPane.XAxis.Title.Text = "";
            //myPane.YAxis.Title.Text = "";

            //// Tạo dữ liệu cho biểu đồ
            //string[] labels = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            //double[] values = { 1.2, 2.3, 3.4, 4.5, 5.6, 1, 1.2, 2.3, 3.4, 4.5, 5.6, 1 };

            //// Tạo đối tượng BarItem để đại diện cho các cột biểu đồ
            //BarItem bar = myPane.AddBar("Doanh thu", null, values, Color.Blue);

            //// Đặt tên cho các cột biểu đồ
            //bar.Bar.Fill = new Fill(Color.Blue);
            //bar.Label.Text = "Doanh thu";

            //// Đặt tên cho các nhãn trục X
            //myPane.XAxis.Scale.TextLabels = labels;

            //// Vẽ biểu đồ
            //zedGraphControl1.AxisChange();
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


        public void getTotalProduct()
        {
            int totalQuantity = _db.TblOrderDetails
                                    .Where(o => o.Date.HasValue && o.Date.Value.Month == 01)
                                    .Sum(o => o.Quantity ?? 0);

            MessageBox.Show("Tổng số sản phẩm được bán trong tháng 1 là: " + totalQuantity.ToString());
        }
        public void getTotalPrice()
        {
            double totalPrice = _db.TblOrders
                                    .Where(o => o.Date.HasValue && o.Date.Value.Month == 1)
                                    .Sum(o => o.TotalPrice.GetValueOrDefault());


            MessageBox.Show("Tổng số sản phẩm được bán trong tháng 1 là: " + totalPrice.ToString());
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

            myPane.XAxis.Title.Text = "Tháng";
            myPane.YAxis.Title.Text = "Tổng giá trị đơn hàng";

            PointPairList list = new PointPairList();

            for (int i = 1; i <= 12; i++)
            {
                double total = GetTotalPriceOfOrdersInMonth(i);
                list.Add(i, total);
            }

            BarItem bar = myPane.AddBar("Tổng giá trị đơn hàng", list, Color.Blue);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrawChart();
        }



        private void Management_Load(object sender, EventArgs e)
        {
            DrawChart();
        }
    }
}
