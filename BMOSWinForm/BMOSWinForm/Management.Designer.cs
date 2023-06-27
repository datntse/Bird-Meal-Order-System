namespace BMOSWinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            panel_control = new System.Windows.Forms.Panel();
            btnHome = new System.Windows.Forms.Button();
            btnProduct = new System.Windows.Forms.Button();
            btnFeedback = new System.Windows.Forms.Button();
            btnBlog = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            btnOrder = new System.Windows.Forms.Button();
            btnAcc = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            panel_body = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            txtTitle = new System.Windows.Forms.Label();
            panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_body.SuspendLayout();
            SuspendLayout();
            // 
            // panel_control
            // 
            panel_control.BackColor = System.Drawing.SystemColors.Desktop;
            panel_control.Controls.Add(btnHome);
            panel_control.Controls.Add(btnProduct);
            panel_control.Controls.Add(btnFeedback);
            panel_control.Controls.Add(btnBlog);
            panel_control.Controls.Add(btnLogout);
            panel_control.Controls.Add(btnOrder);
            panel_control.Controls.Add(btnAcc);
            panel_control.Controls.Add(pictureBox1);
            panel_control.Controls.Add(label1);
            panel_control.Dock = System.Windows.Forms.DockStyle.Left;
            panel_control.Location = new System.Drawing.Point(0, 0);
            panel_control.Name = "panel_control";
            panel_control.Size = new System.Drawing.Size(326, 653);
            panel_control.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackColor = System.Drawing.Color.Chocolate;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnHome.Image = Properties.Resources.business;
            btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHome.Location = new System.Drawing.Point(0, 95);
            btnHome.Name = "btnHome";
            btnHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            btnHome.Size = new System.Drawing.Size(326, 55);
            btnHome.TabIndex = 5;
            btnHome.Text = "   Dashboard";
            btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = System.Drawing.SystemColors.GrayText;
            btnProduct.Enabled = false;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnProduct.Image = Properties.Resources.bird;
            btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProduct.Location = new System.Drawing.Point(0, 199);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            btnProduct.Size = new System.Drawing.Size(326, 55);
            btnProduct.TabIndex = 5;
            btnProduct.Text = "   Quản lý sản phẩm";
            btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnFeedback
            // 
            btnFeedback.BackColor = System.Drawing.SystemColors.GrayText;
            btnFeedback.Enabled = false;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFeedback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFeedback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnFeedback.Image = Properties.Resources.feedback__2_;
            btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFeedback.Location = new System.Drawing.Point(0, 348);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            btnFeedback.Size = new System.Drawing.Size(326, 55);
            btnFeedback.TabIndex = 5;
            btnFeedback.Text = "   Quản lý đánh giá";
            btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFeedback.UseVisualStyleBackColor = false;
            // 
            // btnBlog
            // 
            btnBlog.BackColor = System.Drawing.SystemColors.GrayText;
            btnBlog.Enabled = false;
            btnBlog.FlatAppearance.BorderSize = 0;
            btnBlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBlog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBlog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnBlog.Image = Properties.Resources.blogging;
            btnBlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBlog.Location = new System.Drawing.Point(0, 301);
            btnBlog.Name = "btnBlog";
            btnBlog.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            btnBlog.Size = new System.Drawing.Size(326, 55);
            btnBlog.TabIndex = 5;
            btnBlog.Text = "   Quản lý blog";
            btnBlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBlog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnBlog.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLogout.Image = Properties.Resources.power_off;
            btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogout.Location = new System.Drawing.Point(0, 603);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            btnLogout.Size = new System.Drawing.Size(326, 50);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "   Đăng xuất";
            btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = System.Drawing.SystemColors.GrayText;
            btnOrder.Enabled = false;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnOrder.Image = Properties.Resources.shopping_bag;
            btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOrder.Location = new System.Drawing.Point(0, 251);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            btnOrder.Size = new System.Drawing.Size(326, 55);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "   Quản lý đơn hàng";
            btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnAcc
            // 
            btnAcc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAcc.FlatAppearance.BorderSize = 0;
            btnAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnAcc.Image = Properties.Resources.user;
            btnAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAcc.Location = new System.Drawing.Point(0, 148);
            btnAcc.Name = "btnAcc";
            btnAcc.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            btnAcc.Size = new System.Drawing.Size(326, 55);
            btnAcc.TabIndex = 5;
            btnAcc.Text = "   Quản lý tài khoản";
            btnAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAcc.UseVisualStyleBackColor = false;
            btnAcc.Click += btnAcc_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(42, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(27, 33);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(75, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(232, 33);
            label1.TabIndex = 0;
            label1.Text = "Bảng điều khiển";
            // 
            // panel_body
            // 
            panel_body.Controls.Add(label2);
            panel_body.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_body.Location = new System.Drawing.Point(326, 92);
            panel_body.Name = "panel_body";
            panel_body.Size = new System.Drawing.Size(1171, 561);
            panel_body.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(466, 276);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "dashboard";
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.BackColor = System.Drawing.Color.Chocolate;
            txtTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtTitle.Location = new System.Drawing.Point(807, 9);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(193, 46);
            txtTitle.TabIndex = 3;
            txtTitle.Text = "Dashboard";
            txtTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Management
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1497, 653);
            Controls.Add(txtTitle);
            Controls.Add(panel_body);
            Controls.Add(panel_control);
            MaximizeBox = false;
            Name = "Management";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Management";
            panel_control.ResumeLayout(false);
            panel_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_body.ResumeLayout(false);
            panel_body.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnBlog;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Label txtTitle;
    }
}