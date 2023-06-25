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
	public partial class OrderManagement : Form
	{
		BMOSContext _context;
		public OrderManagement()
		{
			InitializeComponent();
			_context = new BMOSContext();
		}

		private void OrderManagement_Load(object sender, EventArgs e)
		{
			searchOptions.DisplayMember = "";

			var orderList = from order in _context.TblOrders
							select new
							{
								orderId = order.OrderId,
								userId = order.UserId,
								totalPrice = order.TotalPrice,
								date = order.Date,
							};
			dgvOrderList.DataSource = new BindingSource { DataSource = orderList.ToList() };
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
			var keyword = searchKeyword.Text;
			if(keyword != null)
			{
				var result = from order in _context.TblOrders where order.UserId.Equals(keyword)
							select new
							{
								orderId = order.OrderId,
								userId = order.UserId,
								totalPrice = order.TotalPrice,
								date = order.Date,
							};
			dgvOrderList.DataSource = new BindingSource { DataSource = result.ToList() };
			}
		}
	}
}
