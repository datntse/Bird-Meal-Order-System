namespace BMOSWinForm
{
    partial class BlogManagement
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
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            dgvBlog = new System.Windows.Forms.DataGridView();
            btnAdd = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnDetail = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtDate = new System.Windows.Forms.TextBox();
            txtDesc = new System.Windows.Forms.TextBox();
            cbStatus = new System.Windows.Forms.CheckBox();
            btnClear = new System.Windows.Forms.Button();
            cbbSort = new System.Windows.Forms.ComboBox();
            blog_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBlog).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = System.Drawing.SystemColors.MenuText;
            txtSearch.Location = new System.Drawing.Point(14, 16);
            txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(598, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.SystemColors.Control;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSearch.Location = new System.Drawing.Point(619, 16);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(86, 31);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button_Search;
            // 
            // dgvBlog
            // 
            dgvBlog.AllowUserToAddRows = false;
            dgvBlog.AllowUserToDeleteRows = false;
            dgvBlog.AllowUserToResizeColumns = false;
            dgvBlog.AllowUserToResizeRows = false;
            dgvBlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBlog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { blog_id, name, date, status });
            dgvBlog.Location = new System.Drawing.Point(14, 69);
            dgvBlog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvBlog.Name = "dgvBlog";
            dgvBlog.ReadOnly = true;
            dgvBlog.RowHeadersVisible = false;
            dgvBlog.RowHeadersWidth = 51;
            dgvBlog.RowTemplate.Height = 25;
            dgvBlog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvBlog.Size = new System.Drawing.Size(547, 407);
            dgvBlog.TabIndex = 2;
            dgvBlog.CellFormatting += Blog_format;
            dgvBlog.RowEnter += dgvBlog_RowEnter;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.SystemColors.Control;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAdd.Location = new System.Drawing.Point(14, 487);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(86, 51);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button_Add;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = System.Drawing.SystemColors.Control;
            btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEdit.Location = new System.Drawing.Point(106, 487);
            btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(86, 51);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Chỉnh sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += button_Edit;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.SystemColors.Control;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit.Location = new System.Drawing.Point(1040, 487);
            btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(86, 51);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button_Exit;
            // 
            // btnDetail
            // 
            btnDetail.BackColor = System.Drawing.SystemColors.Control;
            btnDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDetail.Location = new System.Drawing.Point(291, 487);
            btnDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new System.Drawing.Size(86, 51);
            btnDetail.TabIndex = 7;
            btnDetail.Text = "Nội dung";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += button_Detail;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.SystemColors.Control;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(199, 487);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(86, 51);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button_Delete;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(578, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 23);
            label1.TabIndex = 8;
            label1.Text = "Mã blog";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(578, 115);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 23);
            label2.TabIndex = 9;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(578, 209);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 23);
            label3.TabIndex = 11;
            label3.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(578, 163);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 23);
            label4.TabIndex = 10;
            label4.Text = "Thời gian";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(578, 255);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(68, 23);
            label6.TabIndex = 12;
            label6.Text = "Miêu tả";
            // 
            // txtId
            // 
            txtId.ForeColor = System.Drawing.SystemColors.MenuText;
            txtId.Location = new System.Drawing.Point(665, 69);
            txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(460, 27);
            txtId.TabIndex = 14;
            // 
            // txtName
            // 
            txtName.ForeColor = System.Drawing.SystemColors.MenuText;
            txtName.Location = new System.Drawing.Point(665, 113);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(460, 27);
            txtName.TabIndex = 15;
            // 
            // txtDate
            // 
            txtDate.ForeColor = System.Drawing.SystemColors.MenuText;
            txtDate.Location = new System.Drawing.Point(665, 161);
            txtDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(460, 27);
            txtDate.TabIndex = 16;
            // 
            // txtDesc
            // 
            txtDesc.ForeColor = System.Drawing.SystemColors.MenuText;
            txtDesc.Location = new System.Drawing.Point(665, 253);
            txtDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new System.Drawing.Size(460, 221);
            txtDesc.TabIndex = 18;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new System.Drawing.Point(670, 213);
            cbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new System.Drawing.Size(18, 17);
            cbStatus.TabIndex = 19;
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.SystemColors.Control;
            btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClear.Location = new System.Drawing.Point(384, 487);
            btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(86, 51);
            btnClear.TabIndex = 20;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button_Clear;
            // 
            // cbbSort
            // 
            cbbSort.FormattingEnabled = true;
            cbbSort.Items.AddRange(new object[] { "Tất cả", "Từ A đến Z", "Blog hoạt động", "Blog không hoạt động" });
            cbbSort.Location = new System.Drawing.Point(762, 16);
            cbbSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbbSort.Name = "cbbSort";
            cbbSort.Size = new System.Drawing.Size(138, 28);
            cbbSort.TabIndex = 21;
            cbbSort.Text = "Tất cả";
            cbbSort.SelectedIndexChanged += ccbSort_SelectedIndexChanged;
            // 
            // blog_id
            // 
            blog_id.DataPropertyName = "BlogId";
            blog_id.HeaderText = "Mã blog";
            blog_id.MinimumWidth = 6;
            blog_id.Name = "blog_id";
            blog_id.ReadOnly = true;
            // 
            // name
            // 
            name.DataPropertyName = "Name";
            name.HeaderText = "Tên";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 250;
            // 
            // date
            // 
            date.DataPropertyName = "Date";
            date.HeaderText = "Thời gian";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // status
            // 
            status.DataPropertyName = "Status";
            status.HeaderText = "Trạng thái";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 110;
            // 
            // BlogManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1139, 553);
            Controls.Add(cbbSort);
            Controls.Add(btnClear);
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
            Controls.Add(btnDetail);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvBlog);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "BlogManagement";
            Text = "Quản lí blog";
            Load += BlogManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBlog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvBlog;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbbSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn blog_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}