namespace BMOSWinForm
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
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            Username = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnlogin = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(186, 219);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(300, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(186, 282);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(300, 27);
            txtPassword.TabIndex = 1;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new System.Drawing.Point(79, 219);
            Username.Name = "Username";
            Username.Size = new System.Drawing.Size(75, 20);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(79, 282);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnlogin
            // 
            btnlogin.Location = new System.Drawing.Point(204, 346);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new System.Drawing.Size(94, 29);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(370, 346);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(94, 29);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(609, 597);
            Controls.Add(btnReset);
            Controls.Add(btnlogin);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnReset;
    }
}