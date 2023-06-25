namespace BMOSWinForm
{
    partial class OrderDetailManagement
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
            orderDetailGridView = new System.Windows.Forms.DataGridView();
            orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            productImg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderDetailGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(orderDetailGridView);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1019, 527);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết đơn hàng";
            // 
            // orderDetailGridView
            // 
            orderDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { orderId, productImg, productId, quantity, price, date });
            orderDetailGridView.Location = new System.Drawing.Point(6, 30);
            orderDetailGridView.Name = "orderDetailGridView";
            orderDetailGridView.RowHeadersWidth = 62;
            orderDetailGridView.RowTemplate.Height = 33;
            orderDetailGridView.Size = new System.Drawing.Size(1007, 491);
            orderDetailGridView.TabIndex = 0;
            orderDetailGridView.CellFormatting += orderDetailGridView_CellFormatting;
            // 
            // orderId
            // 
            orderId.HeaderText = "Mã đơn hàng";
            orderId.MinimumWidth = 8;
            orderId.Name = "orderId";
            orderId.Width = 200;
            // 
            // productImg
            // 
            productImg.HeaderText = "Ảnh sản phẩm";
            productImg.MinimumWidth = 8;
            productImg.Name = "productImg";
            productImg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            productImg.Width = 200;
            // 
            // productId
            // 
            productId.HeaderText = "Mã sản phẩm";
            productId.MinimumWidth = 8;
            productId.Name = "productId";
            productId.Width = 200;
            // 
            // quantity
            // 
            quantity.HeaderText = "Số lượng";
            quantity.MinimumWidth = 8;
            quantity.Name = "quantity";
            quantity.Width = 150;
            // 
            // price
            // 
            price.HeaderText = "Giá sản phẩm";
            price.MinimumWidth = 8;
            price.Name = "price";
            price.Width = 200;
            // 
            // date
            // 
            date.HeaderText = "Ngày thanh toán";
            date.MinimumWidth = 8;
            date.Name = "date";
            date.Width = 200;
            // 
            // OrderDetailManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1043, 551);
            Controls.Add(groupBox1);
            Name = "OrderDetailManagement";
            Text = "OrderDetailManagement";
            Load += OrderDetailManagement_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)orderDetailGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView orderDetailGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}