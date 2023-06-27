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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        }

        public void GetList()
        {
            var list = _userServices.GetAll().Select(p => new
            {
                p.UserId,
                V = p.Firstname + " " + p.Lastname,
                p.Username,
                p.Numberphone,
                p.UserRoleId,
                p.DateCreate,
                p.LastActivitty,
                p.Status
            }).ToList();

            //dgvAccount.DataSource = list.ToList();
            dgvAccount.DataSource = list.ToList();

            dgvAccount.Columns[0].HeaderText = "ID";
            dgvAccount.Columns[1].HeaderText = "Họ Tên";
            dgvAccount.Columns[2].HeaderText = "Email";
            dgvAccount.Columns[3].HeaderText = "Số điện thoại";
            dgvAccount.Columns[4].HeaderText = "Chức vụ";
            dgvAccount.Columns[5].HeaderText = "Ngày khởi tạo";
            dgvAccount.Columns[6].HeaderText = "Hoạt động gần nhất";
            dgvAccount.Columns[7].HeaderText = "Trạng thái";

            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvAccount.DataSource = new BindingSource() { DataSource = list };
            txtUsername.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string type = "add";
            if (username != null && username != "")
            {
                username = null;
                txtUsername.Text = "";
                Form form = new AccountManagementDetail(username, type);
                form.ShowDialog();
            }
            else
            {
                Form form = new AccountManagementDetail(username, type);
                form.ShowDialog();
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (username != null && username != "")
            {
                string type = "details";
                txtUsername.Text = "";
                Form form = new AccountManagementDetail(username, type);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int index = e.RowIndex;
            DataGridViewRow username = dgvAccount.Rows[index];
            txtUsername.Text = username.Cells[2].Value.ToString();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            GetList();
            sortList.Text = "Tất cả";
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            GetList();
            sortList.Text = "Tất cả";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                var result = from user in _db.TblUsers
                             where user.Firstname.Contains(searchKeyword) || user.Lastname.Contains(searchKeyword) || user.Username.Contains(searchKeyword) || user.Numberphone.Contains(searchKeyword)
                             select new
                             {
                                 ID = user.UserId,
                                 Họ_Tên = user.Firstname + " " + user.Lastname,
                                 Email = user.Username,
                                 Số_điện_thoại = user.Numberphone,
                                 Chức_vụ = user.UserRoleId,
                                 Ngày_khởi_tạo = user.DateCreate,
                                 Hoạt_động_gần_nhất = user.LastActivitty,
                                 Trạng_thái = user.Status
                             };


                dgvAccount.DataSource = new BindingSource { DataSource = result.ToList() };
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void sortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string searchKeyword = txtSearch.Text.Trim();
                string sortOption = sortList.SelectedItem?.ToString() ?? "";
                if (!string.IsNullOrEmpty(sortOption))
                {
                    switch (sortOption)
                    {
                        case "Tất cả":
                            GetList();
                            sortList.Text = "Tất cả";
                            break;

                        case "A-Z Tên":
                            var AZ = from user in _db.TblUsers
                                     where user.Firstname.Contains(searchKeyword) || user.Lastname.Contains(searchKeyword) || user.Username.Contains(searchKeyword) || user.Numberphone.Contains(searchKeyword)
                                     orderby user.Lastname ascending
                                     select new
                                     {
                                         ID = user.UserId,
                                         Họ_Tên = user.Firstname + " " + user.Lastname,
                                         Email = user.Username,
                                         Số_điện_thoại = user.Numberphone,
                                         Chức_vụ = user.UserRoleId,
                                         Ngày_khởi_tạo = user.DateCreate,
                                         Hoạt_động_gần_nhất = user.LastActivitty,
                                         Trạng_thái = user.Status
                                     };
                            dgvAccount.DataSource = AZ.ToList();
                            sortList.Text = "A-Z Tên";

                            dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                            break;

                        case "Z-A Tên":
                            var ZA = from user in _db.TblUsers
                                     where user.Firstname.Contains(searchKeyword) || user.Lastname.Contains(searchKeyword) || user.Username.Contains(searchKeyword) || user.Numberphone.Contains(searchKeyword)
                                     orderby user.Lastname descending
                                     select new
                                     {
                                         ID = user.UserId,
                                         Họ_Tên = user.Firstname + " " + user.Lastname,
                                         Email = user.Username,
                                         Số_điện_thoại = user.Numberphone,
                                         Chức_vụ = user.UserRoleId,
                                         Ngày_khởi_tạo = user.DateCreate,
                                         Hoạt_động_gần_nhất = user.LastActivitty,
                                         Trạng_thái = user.Status
                                     };
                            dgvAccount.DataSource = ZA.ToList();
                            sortList.Text = "Z-A Tên";

                            dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                            break;

                        case "A-Z Email":
                            var AZE = from user in _db.TblUsers
                                      where user.Firstname.Contains(searchKeyword) || user.Lastname.Contains(searchKeyword) || user.Username.Contains(searchKeyword) || user.Numberphone.Contains(searchKeyword)
                                      orderby user.Username ascending
                                      select new
                                      {
                                          ID = user.UserId,
                                          Họ_Tên = user.Firstname + " " + user.Lastname,
                                          Email = user.Username,
                                          Số_điện_thoại = user.Numberphone,
                                          Chức_vụ = user.UserRoleId,
                                          Ngày_khởi_tạo = user.DateCreate,
                                          Hoạt_động_gần_nhất = user.LastActivitty,
                                          Trạng_thái = user.Status
                                      };
                            dgvAccount.DataSource = AZE.ToList();
                            dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                            sortList.Text = "A-Z Email";
                            break;

                        case "Z-A Email":
                            var ZAE = from user in _db.TblUsers
                                      where user.Firstname.Contains(searchKeyword) || user.Lastname.Contains(searchKeyword) || user.Username.Contains(searchKeyword) || user.Numberphone.Contains(searchKeyword)
                                      orderby user.Username descending
                                      select new
                                      {
                                          ID = user.UserId,
                                          Họ_Tên = user.Firstname + " " + user.Lastname,
                                          Email = user.Username,
                                          Số_điện_thoại = user.Numberphone,
                                          Chức_vụ = user.UserRoleId,
                                          Ngày_khởi_tạo = user.DateCreate,
                                          Hoạt_động_gần_nhất = user.LastActivitty,
                                          Trạng_thái = user.Status
                                      };
                            dgvAccount.DataSource = ZAE.ToList();
                            sortList.Text = "Z-A Email";

                            dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                            break;

                        case "Nhân viên":
                            var staff = from user in _db.TblUsers
                                        where user.UserRoleId == 2 && user.Firstname.Contains(searchKeyword) || user.UserRoleId == 2 && user.Lastname.Contains(searchKeyword) || user.UserRoleId == 2 && user.Username.Contains(searchKeyword) || user.UserRoleId == 2 && user.Numberphone.Contains(searchKeyword)
                                        orderby user.Lastname ascending
                                        select new
                                        {
                                            ID = user.UserId,
                                            Họ_Tên = user.Firstname + " " + user.Lastname,
                                            Email = user.Username,
                                            Số_điện_thoại = user.Numberphone,
                                            Chức_vụ = user.UserRoleId,
                                            Ngày_khởi_tạo = user.DateCreate,
                                            Hoạt_động_gần_nhất = user.LastActivitty,
                                            Trạng_thái = user.Status
                                        };
                            dgvAccount.DataSource = staff.ToList();
                            sortList.Text = "Nhân viên";

                            dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                            break;

                        case "Khách hàng":
                            var cus = from user in _db.TblUsers
                                      where user.UserRoleId == 3 && user.Firstname.Contains(searchKeyword) || user.UserRoleId == 3 && user.Lastname.Contains(searchKeyword) || user.UserRoleId == 3 && user.Username.Contains(searchKeyword) || user.UserRoleId == 3 && user.Numberphone.Contains(searchKeyword)
                                      orderby user.Lastname ascending
                                      select new
                                      {
                                          ID = user.UserId,
                                          Họ_Tên = user.Firstname + " " + user.Lastname,
                                          Email = user.Username,
                                          Số_điện_thoại = user.Numberphone,
                                          Chức_vụ = user.UserRoleId,
                                          Ngày_khởi_tạo = user.DateCreate,
                                          Hoạt_động_gần_nhất = user.LastActivitty,
                                          Trạng_thái = user.Status
                                      };
                            dgvAccount.DataSource = cus.ToList();
                            sortList.Text = "Khách hàng";

                            dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                            break;

                        case "Hoạt động":
                            var normal = from user in _db.TblUsers
                                      where user.Status == true && user.Firstname.Contains(searchKeyword) || user.Status == true && user.Lastname.Contains(searchKeyword) || user.Status == true && user.Username.Contains(searchKeyword) || user.Status == true && user.Numberphone.Contains(searchKeyword)
                                      orderby user.Lastname ascending
                                      select new
                                      {
                                          ID = user.UserId,
                                          Họ_Tên = user.Firstname + " " + user.Lastname,
                                          Email = user.Username,
                                          Số_điện_thoại = user.Numberphone,
                                          Chức_vụ = user.UserRoleId,
                                          Ngày_khởi_tạo = user.DateCreate,
                                          Hoạt_động_gần_nhất = user.LastActivitty,
                                          Trạng_thái = user.Status
                                      };
                            dgvAccount.DataSource = normal.ToList();
                            sortList.Text = "Hoạt động";

                            dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                            break;

                        case "Vô hiệu hóa":
                            var block = from user in _db.TblUsers
                                        where user.Status == false && user.Firstname.Contains(searchKeyword) || user.Status == false && user.Lastname.Contains(searchKeyword) || user.Status == false && user.Username.Contains(searchKeyword) || user.Status == false && user.Numberphone.Contains(searchKeyword)
                                        orderby user.Lastname ascending
                                        select new
                                      {
                                          ID = user.UserId,
                                          Họ_Tên = user.Firstname + " " + user.Lastname,
                                          Email = user.Username,
                                          Số_điện_thoại = user.Numberphone,
                                          Chức_vụ = user.UserRoleId,
                                          Ngày_khởi_tạo = user.DateCreate,
                                          Hoạt_động_gần_nhất = user.LastActivitty,
                                          Trạng_thái = user.Status
                                      };
                            dgvAccount.DataSource = block.ToList();
                            sortList.Text = "Vô hiệu hóa";

                            dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                            break;


                        case "Hoạt động gần đây":
                            var last = from user in _db.TblUsers
                                       where user.Firstname.Contains(searchKeyword) || user.Lastname.Contains(searchKeyword) || user.Username.Contains(searchKeyword) || user.Numberphone.Contains(searchKeyword)
                                       orderby user.LastActivitty descending
                                        select new
                                        {
                                            ID = user.UserId,
                                            Họ_Tên = user.Firstname + " " + user.Lastname,
                                            Email = user.Username,
                                            Số_điện_thoại = user.Numberphone,
                                            Chức_vụ = user.UserRoleId,
                                            Ngày_khởi_tạo = user.DateCreate,
                                            Hoạt_động_gần_nhất = user.LastActivitty,
                                            Trạng_thái = user.Status
                                        };
                            dgvAccount.DataSource = last.ToList();
                            sortList.Text = "Hoạt động gần đây";

                            dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                            dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                            break;
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {           
            string searchKeyword = txtSearch.Text.Trim();
            if (sortList.Text.Equals("A-Z Email"))
            {
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    var result = from user in _db.TblUsers
                                 where user.Firstname.Contains(searchKeyword) || user.Lastname.Contains(searchKeyword) || user.Username.Contains(searchKeyword) || user.Numberphone.Contains(searchKeyword)
                                 orderby user.Username ascending
                                 select new
                                 {
                                     ID = user.UserId,
                                     Họ_Tên = user.Firstname + " " + user.Lastname,
                                     Email = user.Username,
                                     Số_điện_thoại = user.Numberphone,
                                     Chức_vụ = user.UserRoleId,
                                     Ngày_khởi_tạo = user.DateCreate,
                                     Hoạt_động_gần_nhất = user.LastActivitty,
                                     Trạng_thái = user.Status
                                 };
                    dgvAccount.DataSource = new BindingSource { DataSource = result.ToList() };
                }         
                else
                {
                    var AZE = from user in _db.TblUsers
                              where user.Firstname.Contains(searchKeyword) || user.Lastname.Contains(searchKeyword) || user.Username.Contains(searchKeyword) || user.Numberphone.Contains(searchKeyword)
                              orderby user.Username ascending
                              select new
                              {
                                  ID = user.UserId,
                                  Họ_Tên = user.Firstname + " " + user.Lastname,
                                  Email = user.Username,
                                  Số_điện_thoại = user.Numberphone,
                                  Chức_vụ = user.UserRoleId,
                                  Ngày_khởi_tạo = user.DateCreate,
                                  Hoạt_động_gần_nhất = user.LastActivitty,
                                  Trạng_thái = user.Status
                              };
                    dgvAccount.DataSource = AZE.ToList();
                    sortList.Text = "A-Z Email";

                    dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;                  
                }
            }
            else if (sortList.Text.Equals("Z-A Email"))
            {
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    var result = from user in _db.TblUsers
                                 where user.Firstname.Contains(searchKeyword) || user.Lastname.Contains(searchKeyword) || user.Username.Contains(searchKeyword) || user.Numberphone.Contains(searchKeyword)
                                 orderby user.Username descending
                                 select new
                                 {
                                     ID = user.UserId,
                                     Họ_Tên = user.Firstname + " " + user.Lastname,
                                     Email = user.Username,
                                     Số_điện_thoại = user.Numberphone,
                                     Chức_vụ = user.UserRoleId,
                                     Ngày_khởi_tạo = user.DateCreate,
                                     Hoạt_động_gần_nhất = user.LastActivitty,
                                     Trạng_thái = user.Status
                                 };
                    dgvAccount.DataSource = new BindingSource { DataSource = result.ToList() };
                }
                else
                {
                    var ZAE = from user in _db.TblUsers
                              where user.Firstname.Contains(searchKeyword) || user.Lastname.Contains(searchKeyword) || user.Username.Contains(searchKeyword) || user.Numberphone.Contains(searchKeyword)
                              orderby user.Username descending
                              select new
                              {
                                  ID = user.UserId,
                                  Họ_Tên = user.Firstname + " " + user.Lastname,
                                  Email = user.Username,
                                  Số_điện_thoại = user.Numberphone,
                                  Chức_vụ = user.UserRoleId,
                                  Ngày_khởi_tạo = user.DateCreate,
                                  Hoạt_động_gần_nhất = user.LastActivitty,
                                  Trạng_thái = user.Status
                              };
                    dgvAccount.DataSource = ZAE.ToList();
                    sortList.Text = "Z-A Email";

                    dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                }
            }
            else if (sortList.Text.Equals("A-Z Tên"))
            {
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    var result = from user in _db.TblUsers
                                 where user.UserRoleId == 3 && user.Firstname.Contains(searchKeyword) || user.UserRoleId == 3 && user.Lastname.Contains(searchKeyword) || user.UserRoleId == 3 && user.Username.Contains(searchKeyword) || user.UserRoleId == 3 && user.Numberphone.Contains(searchKeyword)
                                 orderby user.Lastname ascending
                                 select new
                                 {
                                     ID = user.UserId,
                                     Họ_Tên = user.Firstname + " " + user.Lastname,
                                     Email = user.Username,
                                     Số_điện_thoại = user.Numberphone,
                                     Chức_vụ = user.UserRoleId,
                                     Ngày_khởi_tạo = user.DateCreate,
                                     Hoạt_động_gần_nhất = user.LastActivitty,
                                     Trạng_thái = user.Status
                                 };


                    dgvAccount.DataSource = new BindingSource { DataSource = result.ToList() };
                }
                else
                {
                    var AZ = from user in _db.TblUsers
                             where user.Firstname.Contains(searchKeyword) || user.Lastname.Contains(searchKeyword) || user.Username.Contains(searchKeyword) || user.Numberphone.Contains(searchKeyword)
                             orderby user.Lastname ascending
                             select new
                             {
                                 ID = user.UserId,
                                 Họ_Tên = user.Firstname + " " + user.Lastname,
                                 Email = user.Username,
                                 Số_điện_thoại = user.Numberphone,
                                 Chức_vụ = user.UserRoleId,
                                 Ngày_khởi_tạo = user.DateCreate,
                                 Hoạt_động_gần_nhất = user.LastActivitty,
                                 Trạng_thái = user.Status
                             };
                    dgvAccount.DataSource = AZ.ToList();
                    sortList.Text = "A-Z Tên";

                    dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                }
            }
            else if (sortList.Text.Equals("Z-A Tên"))
            {
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    var result = from user in _db.TblUsers
                                 where user.UserRoleId == 2 && user.Firstname.Contains(searchKeyword) || user.UserRoleId == 2 && user.Lastname.Contains(searchKeyword) || user.UserRoleId == 2 && user.Username.Contains(searchKeyword) || user.UserRoleId == 2 && user.Numberphone.Contains(searchKeyword)
                                 orderby user.Lastname ascending
                                 select new
                                 {
                                     ID = user.UserId,
                                     Họ_Tên = user.Firstname + " " + user.Lastname,
                                     Email = user.Username,
                                     Số_điện_thoại = user.Numberphone,
                                     Chức_vụ = user.UserRoleId,
                                     Ngày_khởi_tạo = user.DateCreate,
                                     Hoạt_động_gần_nhất = user.LastActivitty,
                                     Trạng_thái = user.Status
                                 };


                    dgvAccount.DataSource = new BindingSource { DataSource = result.ToList() };
                }
                else
                {
                    var ZA = from user in _db.TblUsers
                             where user.Firstname.Contains(searchKeyword) || user.Lastname.Contains(searchKeyword) || user.Username.Contains(searchKeyword) || user.Numberphone.Contains(searchKeyword)
                             orderby user.Lastname descending
                             select new
                             {
                                 ID = user.UserId,
                                 Họ_Tên = user.Firstname + " " + user.Lastname,
                                 Email = user.Username,
                                 Số_điện_thoại = user.Numberphone,
                                 Chức_vụ = user.UserRoleId,
                                 Ngày_khởi_tạo = user.DateCreate,
                                 Hoạt_động_gần_nhất = user.LastActivitty,
                                 Trạng_thái = user.Status
                             };
                    dgvAccount.DataSource = ZA.ToList();
                    sortList.Text = "Z-A Tên";

                    dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                }
            }
            else if (sortList.Text.Equals("Nhân viên"))
            {
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    var result = from user in _db.TblUsers
                                 where user.UserRoleId == 2 && user.Firstname.Contains(searchKeyword) || user.UserRoleId == 2 && user.Lastname.Contains(searchKeyword) || user.UserRoleId == 2 && user.Username.Contains(searchKeyword) || user.UserRoleId == 2 && user.Numberphone.Contains(searchKeyword)
                                 orderby user.Lastname ascending
                                 select new
                                 {
                                     ID = user.UserId,
                                     Họ_Tên = user.Firstname + " " + user.Lastname,
                                     Email = user.Username,
                                     Số_điện_thoại = user.Numberphone,
                                     Chức_vụ = user.UserRoleId,
                                     Ngày_khởi_tạo = user.DateCreate,
                                     Hoạt_động_gần_nhất = user.LastActivitty,
                                     Trạng_thái = user.Status
                                 };


                    dgvAccount.DataSource = new BindingSource { DataSource = result.ToList() };
                }
                else
                {
                    var staff = from user in _db.TblUsers
                                where user.UserRoleId == 2 && user.Firstname.Contains(searchKeyword) || user.UserRoleId == 2 && user.Lastname.Contains(searchKeyword) || user.UserRoleId == 2 && user.Username.Contains(searchKeyword) || user.UserRoleId == 2 && user.Numberphone.Contains(searchKeyword)
                                orderby user.Lastname ascending
                                select new
                                {
                                    ID = user.UserId,
                                    Họ_Tên = user.Firstname + " " + user.Lastname,
                                    Email = user.Username,
                                    Số_điện_thoại = user.Numberphone,
                                    Chức_vụ = user.UserRoleId,
                                    Ngày_khởi_tạo = user.DateCreate,
                                    Hoạt_động_gần_nhất = user.LastActivitty,
                                    Trạng_thái = user.Status
                                };
                    dgvAccount.DataSource = staff.ToList();
                    sortList.Text = "Nhân viên";

                    dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                }
            }
            else if (sortList.Text.Equals("Khách hàng"))
            {
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    var result = from user in _db.TblUsers
                                 where user.UserRoleId == 3 && user.Firstname.Contains(searchKeyword) || user.UserRoleId == 3 && user.Lastname.Contains(searchKeyword) || user.UserRoleId == 3 && user.Username.Contains(searchKeyword) || user.UserRoleId == 3 && user.Numberphone.Contains(searchKeyword)
                                 orderby user.Lastname ascending
                                 select new
                                 {
                                     ID = user.UserId,
                                     Họ_Tên = user.Firstname + " " + user.Lastname,
                                     Email = user.Username,
                                     Số_điện_thoại = user.Numberphone,
                                     Chức_vụ = user.UserRoleId,
                                     Ngày_khởi_tạo = user.DateCreate,
                                     Hoạt_động_gần_nhất = user.LastActivitty,
                                     Trạng_thái = user.Status
                                 };


                    dgvAccount.DataSource = new BindingSource { DataSource = result.ToList() };
                }
                else
                {
                    var cus = from user in _db.TblUsers
                              where user.UserRoleId == 3 && user.Firstname.Contains(searchKeyword) || user.UserRoleId == 3 && user.Lastname.Contains(searchKeyword) || user.UserRoleId == 3 && user.Username.Contains(searchKeyword) || user.UserRoleId == 3 && user.Numberphone.Contains(searchKeyword)
                              orderby user.Lastname ascending
                              select new
                              {
                                  ID = user.UserId,
                                  Họ_Tên = user.Firstname + " " + user.Lastname,
                                  Email = user.Username,
                                  Số_điện_thoại = user.Numberphone,
                                  Chức_vụ = user.UserRoleId,
                                  Ngày_khởi_tạo = user.DateCreate,
                                  Hoạt_động_gần_nhất = user.LastActivitty,
                                  Trạng_thái = user.Status
                              };
                    dgvAccount.DataSource = cus.ToList();
                    sortList.Text = "Khách hàng";

                    dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                }
            }
            else if (sortList.Text.Equals("Hoạt động"))
            {
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    var result = from user in _db.TblUsers
                                 where user.Status == true && user.Firstname.Contains(searchKeyword) || user.Status == true && user.Lastname.Contains(searchKeyword) || user.Status == true && user.Username.Contains(searchKeyword) || user.Status == true && user.Numberphone.Contains(searchKeyword)
                                 orderby user.Lastname ascending
                                 select new
                                 {
                                     ID = user.UserId,
                                     Họ_Tên = user.Firstname + " " + user.Lastname,
                                     Email = user.Username,
                                     Số_điện_thoại = user.Numberphone,
                                     Chức_vụ = user.UserRoleId,
                                     Ngày_khởi_tạo = user.DateCreate,
                                     Hoạt_động_gần_nhất = user.LastActivitty,
                                     Trạng_thái = user.Status
                                 };


                    dgvAccount.DataSource = new BindingSource { DataSource = result.ToList() };
                }
                else
                {
                    var normal = from user in _db.TblUsers
                                 where user.Status == true && user.Firstname.Contains(searchKeyword) || user.Status == true && user.Lastname.Contains(searchKeyword) || user.Status == true && user.Username.Contains(searchKeyword) || user.Status == true && user.Numberphone.Contains(searchKeyword)
                                 orderby user.Lastname ascending
                                 select new
                                 {
                                     ID = user.UserId,
                                     Họ_Tên = user.Firstname + " " + user.Lastname,
                                     Email = user.Username,
                                     Số_điện_thoại = user.Numberphone,
                                     Chức_vụ = user.UserRoleId,
                                     Ngày_khởi_tạo = user.DateCreate,
                                     Hoạt_động_gần_nhất = user.LastActivitty,
                                     Trạng_thái = user.Status
                                 };
                    dgvAccount.DataSource = normal.ToList();
                    sortList.Text = "Hoạt động";

                    dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                }
            }
            else if (sortList.Text.Equals("Vô hiệu hóa"))
            {
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    var result = from user in _db.TblUsers
                                 where user.Status == false && user.Firstname.Contains(searchKeyword) || user.Status == false && user.Lastname.Contains(searchKeyword) || user.Status == false && user.Username.Contains(searchKeyword) || user.Status == false && user.Numberphone.Contains(searchKeyword)
                                 orderby user.Lastname ascending
                                 select new
                                 {
                                     ID = user.UserId,
                                     Họ_Tên = user.Firstname + " " + user.Lastname,
                                     Email = user.Username,
                                     Số_điện_thoại = user.Numberphone,
                                     Chức_vụ = user.UserRoleId,
                                     Ngày_khởi_tạo = user.DateCreate,
                                     Hoạt_động_gần_nhất = user.LastActivitty,
                                     Trạng_thái = user.Status
                                 };


                    dgvAccount.DataSource = new BindingSource { DataSource = result.ToList() };
                }
                else
                {
                    var block = from user in _db.TblUsers
                                where user.Status == false && user.Firstname.Contains(searchKeyword) || user.Status == false && user.Lastname.Contains(searchKeyword) || user.Status == false && user.Username.Contains(searchKeyword) || user.Status == false && user.Numberphone.Contains(searchKeyword)
                                orderby user.Lastname ascending
                                select new
                                {
                                    ID = user.UserId,
                                    Họ_Tên = user.Firstname + " " + user.Lastname,
                                    Email = user.Username,
                                    Số_điện_thoại = user.Numberphone,
                                    Chức_vụ = user.UserRoleId,
                                    Ngày_khởi_tạo = user.DateCreate,
                                    Hoạt_động_gần_nhất = user.LastActivitty,
                                    Trạng_thái = user.Status
                                };
                    dgvAccount.DataSource = block.ToList();
                    sortList.Text = "Vô hiệu hóa";

                    dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                }
            }
            else if (sortList.Text.Equals("Hoạt động gần đây"))
            {
                if (!string.IsNullOrEmpty(searchKeyword))
                {
                    var result = from user in _db.TblUsers
                                 where user.Firstname.Contains(searchKeyword) || user.Lastname.Contains(searchKeyword) || user.Username.Contains(searchKeyword) || user.Numberphone.Contains(searchKeyword)
                                 orderby user.LastActivitty descending
                                 select new
                                 {
                                     ID = user.UserId,
                                     Họ_Tên = user.Firstname + " " + user.Lastname,
                                     Email = user.Username,
                                     Số_điện_thoại = user.Numberphone,
                                     Chức_vụ = user.UserRoleId,
                                     Ngày_khởi_tạo = user.DateCreate,
                                     Hoạt_động_gần_nhất = user.LastActivitty,
                                     Trạng_thái = user.Status
                                 };

                    dgvAccount.DataSource = new BindingSource { DataSource = result.ToList() };
                }
                else
                {
                    var last = from user in _db.TblUsers
                               where user.Firstname.Contains(searchKeyword) || user.Lastname.Contains(searchKeyword) || user.Username.Contains(searchKeyword) || user.Numberphone.Contains(searchKeyword)
                               orderby user.LastActivitty descending
                               select new
                               {
                                   ID = user.UserId,
                                   Họ_Tên = user.Firstname + " " + user.Lastname,
                                   Email = user.Username,
                                   Số_điện_thoại = user.Numberphone,
                                   Chức_vụ = user.UserRoleId,
                                   Ngày_khởi_tạo = user.DateCreate,
                                   Hoạt_động_gần_nhất = user.LastActivitty,
                                   Trạng_thái = user.Status
                               };
                    dgvAccount.DataSource = last.ToList();
                    sortList.Text = "Hoạt động gần đây";

                    dgvAccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    dgvAccount.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAccount.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                }
            }
            
        }
    }
}
