using ElectricStore_Datnt.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStore_Datnt
{
	public partial class Management : Form
	{
		UserService _userService;
		public Management()
		{
			InitializeComponent();
			_userService = new UserService();
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			var username = txtUserName.Text;
			var password = txtPassword.Text;



			var result = _userService.GetAll().Where(u => u.UserName.Equals(username) && u.Password.Equals(password)).FirstOrDefault();
			if (result != null)
			{
				this.Hide();
				Manager manager = new Manager();
				manager.Show();
			}
			else
			{
				MessageBox.Show("Sorry, you are not allowed to access", "Message", MessageBoxButtons.OK);
			}

		}
	}
}
