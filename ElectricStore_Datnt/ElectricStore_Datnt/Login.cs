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

namespace ElectricStore_Datnt
{
	public partial class Login : Form
	{
		UserService _userService;
		public Login()
		{
			_userService = new UserService();
			InitializeComponent();
		}
		private void btnLogin_Click(object sender, EventArgs e)
		{
			var username = txtUsername.Text;
			var password = txtPassword.Text;	

			var result = _userService.GetAll().Where(x => x.UserName.Equals(username) && x.Password.Equals(password)).FirstOrDefault();
			if (result != null)
			{
				if (result.UserRole == 1)
				{
					this.Hide();
					Manager manager = new Manager();
					manager.Show();
				} else
				{
					MessageBox.Show("Sorry, you are not allowed to access", "Message", MessageBoxButtons.OK);
				}
			} else
			{
				MessageBox.Show("Error information!!", "Message", MessageBoxButtons.OK);
			}


		}
		private void resetBtn_Click(object sender, EventArgs e)
		{
			txtUsername.Text = "";
			txtPassword.Text = "";
		}
	}
}
