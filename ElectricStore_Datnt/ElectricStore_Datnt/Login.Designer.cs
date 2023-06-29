using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElectricStore_Datnt
{
	partial class Login
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnLogin = new Button();
			txtPassword = new TextBox();
			txtUsername = new TextBox();
			label2 = new Label();
			label1 = new Label();
			label3 = new Label();
			sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
			resetBtn = new Button();
			SuspendLayout();
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(490, 357);
			btnLogin.Margin = new Padding(4);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(118, 36);
			btnLogin.TabIndex = 9;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(349, 278);
			txtPassword.Margin = new Padding(4);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(259, 31);
			txtPassword.TabIndex = 8;
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(349, 211);
			txtUsername.Margin = new Padding(4);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(259, 31);
			txtUsername.TabIndex = 7;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(218, 284);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(87, 25);
			label2.TabIndex = 6;
			label2.Text = "Password";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(218, 214);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(91, 25);
			label1.TabIndex = 5;
			label1.Text = "Username";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.Highlight;
			label3.Location = new Point(218, 107);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(102, 38);
			label3.TabIndex = 10;
			label3.Text = "LOGIN";
			label3.TextAlign = ContentAlignment.TopCenter;
			// 
			// sqlDataAdapter1
			// 
			sqlDataAdapter1.DeleteCommand = null;
			sqlDataAdapter1.InsertCommand = null;
			sqlDataAdapter1.SelectCommand = null;
			sqlDataAdapter1.UpdateCommand = null;
			// 
			// resetBtn
			// 
			resetBtn.Location = new Point(326, 357);
			resetBtn.Margin = new Padding(4);
			resetBtn.Name = "resetBtn";
			resetBtn.Size = new Size(118, 36);
			resetBtn.TabIndex = 11;
			resetBtn.Text = "Reset";
			resetBtn.UseVisualStyleBackColor = true;
			resetBtn.Click += resetBtn_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1000, 562);
			Controls.Add(resetBtn);
			Controls.Add(label3);
			Controls.Add(btnLogin);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(label2);
			Controls.Add(label1);
			Margin = new Padding(4);
			Name = "Login";
			Text = "Login";
			ResumeLayout(false);
			PerformLayout();
		}



		#endregion

		private Button btnLogin;
		private TextBox txtPassword;
		private TextBox txtUsername;
		private Label label2;
		private Label label1;
		private Label label3;
		private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private Button resetBtn;
	}
}