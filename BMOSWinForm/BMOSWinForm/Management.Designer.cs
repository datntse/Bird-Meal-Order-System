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
            components = new System.ComponentModel.Container();
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
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            zedGraphControl1 = new ZedGraph.ZedGraphControl();
            txtTitle = new System.Windows.Forms.Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            panel_body.Controls.Add(label10);
            panel_body.Controls.Add(label11);
            panel_body.Controls.Add(label12);
            panel_body.Controls.Add(label13);
            panel_body.Controls.Add(label6);
            panel_body.Controls.Add(label7);
            panel_body.Controls.Add(label8);
            panel_body.Controls.Add(label9);
            panel_body.Controls.Add(label4);
            panel_body.Controls.Add(label5);
            panel_body.Controls.Add(label3);
            panel_body.Controls.Add(label2);
            panel_body.Controls.Add(button1);
            panel_body.Controls.Add(zedGraphControl1);
            panel_body.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_body.Location = new System.Drawing.Point(326, 92);
            panel_body.Name = "panel_body";
            panel_body.Size = new System.Drawing.Size(1171, 561);
            panel_body.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(990, 507);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(35, 20);
            label10.TabIndex = 27;
            label10.Text = "Dec";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(914, 506);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(36, 20);
            label11.TabIndex = 26;
            label11.Text = "Nov";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(844, 507);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(32, 20);
            label12.TabIndex = 25;
            label12.Text = "Oct";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(768, 506);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(34, 20);
            label13.TabIndex = 24;
            label13.Text = "Sep";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(695, 506);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(36, 20);
            label6.TabIndex = 23;
            label6.Text = "Aug";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(619, 508);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(26, 20);
            label7.TabIndex = 22;
            label7.Text = "Jul";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(549, 508);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(30, 20);
            label8.TabIndex = 21;
            label8.Text = "Jun";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(473, 507);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(37, 20);
            label9.TabIndex = 20;
            label9.Text = "May";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(400, 507);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(33, 20);
            label4.TabIndex = 19;
            label4.Text = "Apr";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(324, 508);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(35, 20);
            label5.TabIndex = 18;
            label5.Text = "Mar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(254, 509);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 20);
            label3.TabIndex = 17;
            label3.Text = "Feb";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(178, 508);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 20);
            label2.TabIndex = 4;
            label2.Text = "Jan";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(101, 476);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(1070, 85);
            button1.TabIndex = 16;
            button1.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            zedGraphControl1.Name = "zedGraphControl1";
            zedGraphControl1.ScrollGrace = 0D;
            zedGraphControl1.ScrollMaxX = 0D;
            zedGraphControl1.ScrollMaxY = 0D;
            zedGraphControl1.ScrollMaxY2 = 0D;
            zedGraphControl1.ScrollMinX = 0D;
            zedGraphControl1.ScrollMinY = 0D;
            zedGraphControl1.ScrollMinY2 = 0D;
            zedGraphControl1.Size = new System.Drawing.Size(1171, 561);
            zedGraphControl1.TabIndex = 1;
            zedGraphControl1.UseExtendedPrintDialog = true;
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
            Load += Management_Load;
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
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Label txtTitle;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}