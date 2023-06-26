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
            pictureBox2 = new System.Windows.Forms.PictureBox();
            btnHome = new System.Windows.Forms.Button();
            btnMsg = new System.Windows.Forms.Button();
            btnProduct = new System.Windows.Forms.Button();
            btnFeedback = new System.Windows.Forms.Button();
            pic2 = new System.Windows.Forms.PictureBox();
            btnBlog = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            btnOrder = new System.Windows.Forms.Button();
            btnAcc = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            panel_body = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_body.SuspendLayout();
            SuspendLayout();
            // 
            // panel_control
            // 
            panel_control.BackColor = System.Drawing.SystemColors.Desktop;
            panel_control.Controls.Add(pictureBox2);
            panel_control.Controls.Add(btnHome);
            panel_control.Controls.Add(btnMsg);
            panel_control.Controls.Add(btnProduct);
            panel_control.Controls.Add(btnFeedback);
            panel_control.Controls.Add(pic2);
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
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(75, 615);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(37, 35);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = System.Drawing.Color.Chocolate;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnHome.Location = new System.Drawing.Point(0, 92);
            btnHome.Name = "btnHome";
            btnHome.Size = new System.Drawing.Size(326, 55);
            btnHome.TabIndex = 5;
            btnHome.Text = "Dashboard";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnMsg
            // 
            btnMsg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnMsg.FlatAppearance.BorderSize = 0;
            btnMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMsg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnMsg.Location = new System.Drawing.Point(0, 441);
            btnMsg.Name = "btnMsg";
            btnMsg.Size = new System.Drawing.Size(326, 55);
            btnMsg.TabIndex = 5;
            btnMsg.Text = " Quản lý liên hệ";
            btnMsg.UseVisualStyleBackColor = false;
            btnMsg.Click += btnMsg_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnProduct.Location = new System.Drawing.Point(0, 197);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new System.Drawing.Size(326, 55);
            btnProduct.TabIndex = 5;
            btnProduct.Text = " Quản lý sản phẩm";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFeedback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnFeedback.Location = new System.Drawing.Point(3, 380);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new System.Drawing.Size(326, 55);
            btnFeedback.TabIndex = 5;
            btnFeedback.Text = " Quản lý đánh giá";
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // pic2
            // 
            pic2.Anchor = System.Windows.Forms.AnchorStyles.None;
            pic2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            pic2.Image = (System.Drawing.Image)resources.GetObject("pic2.Image");
            pic2.Location = new System.Drawing.Point(75, 154);
            pic2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pic2.Name = "pic2";
            pic2.Size = new System.Drawing.Size(31, 36);
            pic2.TabIndex = 6;
            pic2.TabStop = false;
            // 
            // btnBlog
            // 
            btnBlog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnBlog.FlatAppearance.BorderSize = 0;
            btnBlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBlog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnBlog.Location = new System.Drawing.Point(0, 319);
            btnBlog.Name = "btnBlog";
            btnBlog.Size = new System.Drawing.Size(326, 55);
            btnBlog.TabIndex = 5;
            btnBlog.Text = " Quản lý blog";
            btnBlog.UseVisualStyleBackColor = false;
            btnBlog.Click += btnBlog_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLogout.Location = new System.Drawing.Point(0, 609);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(326, 44);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnOrder.Location = new System.Drawing.Point(0, 258);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new System.Drawing.Size(326, 55);
            btnOrder.TabIndex = 5;
            btnOrder.Text = " Quản lý đơn hàng";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnAcc
            // 
            btnAcc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAcc.FlatAppearance.BorderSize = 0;
            btnAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnAcc.Location = new System.Drawing.Point(0, 141);
            btnAcc.Name = "btnAcc";
            btnAcc.Size = new System.Drawing.Size(326, 55);
            btnAcc.TabIndex = 5;
            btnAcc.Text = "Quản lý tài khoản";
            btnAcc.UseVisualStyleBackColor = false;
            btnAcc.Click += btnAcc_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(27, 35);
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
            // Management
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1497, 653);
            Controls.Add(panel_body);
            Controls.Add(panel_control);
            MaximizeBox = false;
            Name = "Management";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Management";
            panel_control.ResumeLayout(false);
            panel_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_body.ResumeLayout(false);
            panel_body.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btnMsg;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnBlog;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}