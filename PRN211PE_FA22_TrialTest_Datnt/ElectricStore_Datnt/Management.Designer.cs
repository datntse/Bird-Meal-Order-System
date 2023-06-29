namespace ElectricStore_Datnt
{
	partial class Management
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
			label1 = new System.Windows.Forms.Label();
			txtUserName = new System.Windows.Forms.TextBox();
			txtPassword = new System.Windows.Forms.TextBox();
			label2 = new System.Windows.Forms.Label();
			loginBtn = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(156, 148);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(89, 25);
			label1.TabIndex = 0;
			label1.Text = "username";
			// 
			// txtUserName
			// 
			txtUserName.Location = new System.Drawing.Point(251, 145);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new System.Drawing.Size(213, 31);
			txtUserName.TabIndex = 1;
			// 
			// txtPassword
			// 
			txtPassword.Location = new System.Drawing.Point(251, 204);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new System.Drawing.Size(213, 31);
			txtPassword.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(156, 207);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(89, 25);
			label2.TabIndex = 2;
			label2.Text = "password";
			// 
			// loginBtn
			// 
			loginBtn.Location = new System.Drawing.Point(251, 258);
			loginBtn.Name = "loginBtn";
			loginBtn.Size = new System.Drawing.Size(112, 34);
			loginBtn.TabIndex = 4;
			loginBtn.Text = "Login";
			loginBtn.UseVisualStyleBackColor = true;
			loginBtn.Click += loginBtn_Click;
			// 
			// Management
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(loginBtn);
			Controls.Add(txtPassword);
			Controls.Add(label2);
			Controls.Add(txtUserName);
			Controls.Add(label1);
			Name = "Management";
			Text = "Management";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button loginBtn;
	}
}