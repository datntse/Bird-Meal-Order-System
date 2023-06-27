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

        private Image ConvertBitmapToImage(Bitmap bitmap)
        {
            // Convert the Bitmap to an Image
            Image image = new Bitmap(bitmap);

            // Do something with the Image, for example display it in a PictureBox
            return image;
        }
        private async void OrderDetailManagement_Load(object sender, EventArgs e)
        {

            using (var client = new WebClient())
            {

                var result = from product in _context.TblOrderDetails
                             from image in _context.TblImages
                             where product.ProductId == image.RelationId && product.OrderId == _orderId
                             select new
                             {
                                 orderId = product.OrderId,
                                 imageLink = image.Url,
                                 productId = product.ProductId,
                                 quantity = product.Quantity,
                                 price = product.Price,
                                 date = product.Date.ToString()
                             };

                orderDetailGridView.Columns["productImg"].Visible = false;

                // Resize the image column to fit the images
                orderDetailGridView.AutoResizeColumn(orderDetailGridView.Columns["productImg"].Index, DataGridViewAutoSizeColumnMode.DisplayedCells);

                foreach (var order in result)
                {
                    string[] stringSeparators = new string[] { "datnt" };
                    string[] images = order.imageLink.Split(stringSeparators, StringSplitOptions.None);
                    var image = images[0];

                    //var imageData = await client.DownloadDataTaskAsync(image);
                    //var producPic = Image.FromStream(new MemoryStream(imageData));
                    // Add the image to the table	
                    orderDetailGridView.Rows.Add(order.orderId, image, order.productId, order.quantity, order.price, order.date);
                    orderDetailGridView.AutoResizeColumn(orderDetailGridView.Columns["productImg"].Index, DataGridViewAutoSizeColumnMode.DisplayedCells);
                }

            }


        }
        public static Image GetImageFromUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            // if you have proxy server, you may need to set proxy details like below 
            //httpWebRequest.Proxy = new WebProxy("proxyserver",port){ Credentials = new NetworkCredential(){ UserName ="uname", Password = "pw"}};

            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
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