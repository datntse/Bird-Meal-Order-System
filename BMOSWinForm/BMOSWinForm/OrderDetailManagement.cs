using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMOSWinForm
{
    public partial class OrderDetailManagement : Form
    {
        BMOSContext _context;
        private string _orderId;
        private List<String> imgLink;

        public OrderDetailManagement(string orderId)
        {
            _orderId = orderId;
            _context = new BMOSContext();
            InitializeComponent();
        }

        private async void OrderDetailManagement_Load(object sender, EventArgs e)
        {
                var result = from product in _context.TblOrderDetails
                             where  product.OrderId == _orderId
                             select new
                             {
                                 orderId = product.OrderId,
                                 productId = product.ProductId,
                                 quantity = product.Quantity,
                                 price = product.Price,
                                 date = product.Date.ToString()
                             };

                // Resize the image column to fit the images

                foreach (var order in result)
                {
                    orderDetailGridView.Rows.Add(order.orderId, order.productId, order.quantity, order.price, order.date);
                    orderDetailGridView.AutoResizeColumn(orderDetailGridView.Columns["productImg"].Index, DataGridViewAutoSizeColumnMode.DisplayedCells);
                }
        }
  
        private void orderDetailGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (orderDetailGridView.Columns[e.ColumnIndex].Name == "productImg")
            {

            }
        }
    }
}