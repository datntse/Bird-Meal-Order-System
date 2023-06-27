using Microsoft.VisualBasic.ApplicationServices;
using Repository.Models.Entities;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
namespace BMOSWinForm
{
    public partial class ProductManagementDetail : Form
    {
        private string _productname;
        private string _producttype;
        BMOSContext _db;
        TblProductServices _productServices;
        TblProduct _product;
        public ProductManagementDetail()
        {
            InitializeComponent();
            _db = new BMOSContext();
            _productServices = new TblProductServices();
            _product = new TblProduct();
        }
        public ProductManagementDetail(string productname, string producttype) : this()
        {
            _productname = productname;
            _producttype = producttype;
            if (_producttype.Equals("details"))
            {
                txtId.Text = _db.TblProducts.Where(p => p.Name.Equals(_productname)).Select(p => p.ProductId).First();
                txtName.Text = _productname;
                txtDescription.Text = _db.TblProducts.Where(p => p.Name.Equals(_productname)).Select(p => p.Description).First();
                txtType.Text = _db.TblProducts.Where(p => p.Name.Equals(_productname)).Select(p => p.Type).First();
                txtPrice.Text = _db.TblProducts.Where(p => p.Name.Equals(_productname)).Select(p => p.Price).First().ToString();
                txtQuantity.Text = _db.TblProducts.Where(p => p.Name.Equals(_productname)).Select(p => p.Quantity).First().ToString();
                txtWeight.Text = _db.TblProducts.Where(p => p.Name.Equals(_productname)).Select(p => p.Weight).First().ToString();
                txtStatus.Text = _db.TblProducts.Where(p => p.Name.Equals(_productname)).Select(p => p.Status).First().ToString();
                lb_productname.Text = _productname;
                bool status = (bool)_db.TblProducts.Where(p => p.Name.Equals(_productname)).Select(p => p.Status).First();
                if (status)
                {
                    txtStatus.Text = "Còn Hàng";
                }
                else
                {
                    txtStatus.Text = "Hết hàng";
                }
                txtStatus.Enabled = false;
                txtPrice.Enabled = false;
                txtWeight.Enabled = false;
                txtQuantity.Enabled = false;
                txtWeight.Enabled = false;
                txtDescription.Enabled = false;
                txtId.Enabled = false;
                txtName.Enabled = false;
                txtType.Enabled = false;

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
