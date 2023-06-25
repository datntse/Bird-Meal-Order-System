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

namespace BMOSWinForm
{
    public partial class AccountManagement : Form
    {
        BMOSContext _db;
        TblUserServices _userServices;

        public AccountManagement()
        {
            InitializeComponent();

            _db = new BMOSContext();
            _userServices = new TblUserServices();

            var list = _userServices.GetAll().Select(p => new
            {
                p.UserId,
                V = p.Firstname + " " + p.Lastname,
                p.Username,
                p.Password,
                p.Numberphone,
                p.UserRoleId,
                p.DateCreate,
                p.LastActivitty,
                p.Status
            }).ToList();

            dgvAccount.DataSource = list.ToList();

            dgvAccount.Columns[0].HeaderText = "ID";
            dgvAccount.Columns[1].HeaderText = "Họ Tên";
            dgvAccount.Columns[2].HeaderText = "Email";
            dgvAccount.Columns[3].HeaderText = "Mật khẩu";
            dgvAccount.Columns[4].HeaderText = "Số điện thoại";
            dgvAccount.Columns[5].HeaderText = "Chức vụ";
            dgvAccount.Columns[6].HeaderText = "Ngày khởi tạo";
            dgvAccount.Columns[7].HeaderText = "Hoạt động gần nhất";
            dgvAccount.Columns[8].HeaderText = "Trạng thái";

            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAccount.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }
    }
}
