namespace BMOSWinForm
{
    partial class OrderManagement
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            panel_body = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            searchOptions = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            searchBtn = new System.Windows.Forms.Button();
            searchKeyword = new System.Windows.Forms.TextBox();
            dgvOrderList = new System.Windows.Forms.DataGridView();
            orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            isConfirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            viewOrderDetailBtn = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            txtOrderId = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel_body);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(searchOptions);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(searchBtn);
            groupBox1.Controls.Add(searchKeyword);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1119, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lí đơn hàng";
            // 
            // panel_body
            // 
            panel_body.Location = new System.Drawing.Point(0, 87);
            panel_body.Name = "panel_body";
            panel_body.Size = new System.Drawing.Size(1119, 485);
            panel_body.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(692, 37);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 25);
            label3.TabIndex = 4;
            label3.Text = "Trạng thái:";
            // 
            // searchOptions
            // 
            searchOptions.FormattingEnabled = true;
            searchOptions.Items.AddRange(new object[] { "Đã xác nhận", "Chưa xác nhận" });
            searchOptions.Location = new System.Drawing.Point(791, 34);
            searchOptions.Name = "searchOptions";
            searchOptions.Size = new System.Drawing.Size(182, 33);
            searchOptions.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 25);
            label1.TabIndex = 2;
            label1.Text = "Từ khóa";
            // 
            // searchBtn
            // 
            searchBtn.Location = new System.Drawing.Point(989, 18);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new System.Drawing.Size(124, 63);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Tìm kiếm";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchKeyword
            // 
            searchKeyword.Location = new System.Drawing.Point(148, 34);
            searchKeyword.Name = "searchKeyword";
            searchKeyword.Size = new System.Drawing.Size(516, 31);
            searchKeyword.TabIndex = 0;
            // 
            // dgvOrderList
            // 
            dgvOrderList.AllowUserToAddRows = false;
            dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { orderId, userId, totalPrice, date, isConfirm });
            dgvOrderList.Location = new System.Drawing.Point(12, 99);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 62;
            dgvOrderList.RowTemplate.Height = 33;
            dgvOrderList.Size = new System.Drawing.Size(1119, 485);
            dgvOrderList.TabIndex = 1;
            dgvOrderList.CellContentClick += dgvOrderList_CellContentClick;
            dgvOrderList.CellFormatting += dgvOrderList_CellFormatting;
            // 
            // orderId
            // 
            orderId.HeaderText = "Mã Order";
            orderId.MinimumWidth = 8;
            orderId.Name = "orderId";
            orderId.Width = 150;
            // 
            // userId
            // 
            userId.HeaderText = "Mã khách hàng";
            userId.MinimumWidth = 8;
            userId.Name = "userId";
            userId.Width = 200;
            // 
            // totalPrice
            // 
            totalPrice.HeaderText = "Tổng giá tiền";
            totalPrice.MinimumWidth = 8;
            totalPrice.Name = "totalPrice";
            totalPrice.Width = 150;
            // 
            // date
            // 
            date.HeaderText = "Ngày thanh toán";
            date.MinimumWidth = 8;
            date.Name = "date";
            date.Width = 200;
            // 
            // isConfirm
            // 
            isConfirm.HeaderText = "Trạng thái";
            isConfirm.MinimumWidth = 8;
            isConfirm.Name = "isConfirm";
            isConfirm.Width = 150;
            // 
            // viewOrderDetailBtn
            // 
            viewOrderDetailBtn.Location = new System.Drawing.Point(150, 643);
            viewOrderDetailBtn.Name = "viewOrderDetailBtn";
            viewOrderDetailBtn.Size = new System.Drawing.Size(118, 31);
            viewOrderDetailBtn.TabIndex = 2;
            viewOrderDetailBtn.Text = "Chi tiết";
            viewOrderDetailBtn.UseVisualStyleBackColor = true;
            viewOrderDetailBtn.Click += viewOrderDetailBtn_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(1019, 628);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(112, 61);
            button3.TabIndex = 4;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new System.Drawing.Point(12, 643);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new System.Drawing.Size(120, 31);
            txtOrderId.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 613);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 25);
            label2.TabIndex = 4;
            label2.Text = "Mã order:";
            // 
            // OrderManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 750);
            Controls.Add(label2);
            Controls.Add(txtOrderId);
            Controls.Add(button3);
            Controls.Add(viewOrderDetailBtn);
            Controls.Add(dgvOrderList);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "OrderManagement";
            Text = "OrderManagement";
            Load += OrderManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchKeyword;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Button viewOrderDetailBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox searchOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn isConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_body;
    }
}