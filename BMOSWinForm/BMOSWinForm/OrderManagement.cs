using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
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
    public partial class OrderManagement : Form
    {
        BMOSContext _context;
        private Form currentChildForm;

        public OrderManagement()
        {
            InitializeComponent();
            _context = new BMOSContext();

        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            if (searchOptions.Items.Count > 0)
            {
                searchOptions.SelectedIndex = -1;
                searchOptions.SelectedText = "Mặc định";
            }
            searchOptions.DisplayMember = "";
            var _orderList = from order in _context.TblOrders
                             select new
                             {
                                 orderId = order.OrderId,
                                 userId = order.UserId,
                                 totalPrice = order.TotalPrice,
                                 date = order.Date.ToString(),
                                 isConfirm = order.IsConfirm,
                             };
            foreach (var order in _orderList)
            {
                string confirmValue = null;
                confirmValue = (bool)order.isConfirm ? "Đã xác nhận" : "Chưa xác nhận";

                dgvOrderList.Rows.Add(order.orderId, order.userId, order.totalPrice, order.date, confirmValue);
            }


        }

        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderId.Enabled = false;
            var orderId = dgvOrderList[0, e.RowIndex].Value;
            var order = _context.TblOrders.Where(o => o.OrderId.Equals(orderId)).FirstOrDefault();
            if (order != null)
            {
                txtOrderId.Text = order.OrderId;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var _orderList = from order in _context.TblOrders
                             select new
                             {
                                 orderId = order.OrderId,
                                 userId = order.UserId,
                                 totalPrice = order.TotalPrice,
                                 date = order.Date.ToString(),
                                 isConfirm = order.IsConfirm,
                             };
            var keyword = searchKeyword.Text;
            if (keyword.Length > 0)
            {
                dgvOrderList.Rows.Clear();
                var result = _orderList.Where(x => x.userId.Contains(keyword));

                if (searchOptions.SelectedIndex == 0) result = _orderList.Where(x => x.userId.Contains(keyword) && x.isConfirm == true);
                else if (searchOptions.SelectedIndex == 1) result = _orderList.Where(x => x.userId.Contains(keyword) && x.isConfirm == false);

                if (result.Count() == 0)
                {
                    MessageBox.Show("Khách hàng này chưa có đơn hàng trong hệ thống!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    foreach (var order in result)
                    {
                        string confirmValue = null;
                        confirmValue = (bool)order.isConfirm ? "Đã xác nhận" : "Chưa xác nhận";
                        dgvOrderList.Rows.Add(order.orderId, order.userId, order.totalPrice, order.date, confirmValue);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào id khác hàng mà bạn muốn tìm kiếm!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dgvOrderList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status.Equals("Đã xác nhận"))
                {
                    e.CellStyle.BackColor = Color.Green;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void viewOrderDetailBtn_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;
            OrderDetailManagement orderDetailManagement = new OrderDetailManagement(orderId);
            this.Hide();
            orderDetailManagement.ShowDialog();
            //orderDetailManagement = null;
            this.Show();
        }
    }
}