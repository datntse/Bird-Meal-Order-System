namespace BMOSWinForm
{
    partial class BlogDetail
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
            cbStatus = new System.Windows.Forms.CheckBox();
            txtDesc = new System.Windows.Forms.TextBox();
            txtDate = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtId = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.Button();
            lbBlogName = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new System.Drawing.Point(225, 274);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new System.Drawing.Size(15, 14);
            cbStatus.TabIndex = 30;
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // txtDesc
            // 
            txtDesc.ForeColor = System.Drawing.SystemColors.MenuText;
            txtDesc.Location = new System.Drawing.Point(221, 304);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtDesc.Size = new System.Drawing.Size(403, 167);
            txtDesc.TabIndex = 29;
            // 
            // txtDate
            // 
            txtDate.ForeColor = System.Drawing.SystemColors.MenuText;
            txtDate.Location = new System.Drawing.Point(221, 235);
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(403, 23);
            txtDate.TabIndex = 28;
            // 
            // txtName
            // 
            txtName.ForeColor = System.Drawing.SystemColors.MenuText;
            txtName.Location = new System.Drawing.Point(221, 199);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(403, 23);
            txtName.TabIndex = 27;
            // 
            // txtId
            // 
            txtId.ForeColor = System.Drawing.SystemColors.MenuText;
            txtId.Location = new System.Drawing.Point(221, 166);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(403, 23);
            txtId.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(153, 305);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(52, 17);
            label6.TabIndex = 25;
            label6.Text = "Miêu tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(153, 271);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 17);
            label3.TabIndex = 24;
            label3.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(153, 236);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 17);
            label4.TabIndex = 23;
            label4.Text = "Thời gian";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(153, 200);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 17);
            label2.TabIndex = 22;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(153, 167);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 17);
            label1.TabIndex = 21;
            label1.Text = "Mã blog";
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.SystemColors.Control;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit.Location = new System.Drawing.Point(549, 479);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(75, 38);
            btnExit.TabIndex = 20;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnThoát;
            // 
            // lbBlogName
            // 
            lbBlogName.AutoSize = true;
            lbBlogName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbBlogName.Location = new System.Drawing.Point(153, 91);
            lbBlogName.Name = "lbBlogName";
            lbBlogName.Size = new System.Drawing.Size(133, 32);
            lbBlogName.TabIndex = 31;
            lbBlogName.Text = "BlogName";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Chocolate;
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 55);
            panel1.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Chocolate;
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 542);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(800, 54);
            panel2.TabIndex = 33;
            // 
            // BlogDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 596);
            Controls.Add(lbBlogName);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cbStatus);
            Controls.Add(txtDesc);
            Controls.Add(txtDate);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Name = "BlogDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "BlogDetail";
            Load += BlogDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbBlogName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}