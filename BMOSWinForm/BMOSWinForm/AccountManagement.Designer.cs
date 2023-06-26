namespace BMOSWinForm
{
    partial class AccountManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            panel_top = new System.Windows.Forms.Panel();
            sortList = new System.Windows.Forms.ComboBox();
            btnSearch = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            dgvAccount = new System.Windows.Forms.DataGridView();
            btnDetail = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtUsername = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnRef = new System.Windows.Forms.Button();
            panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.Controls.Add(sortList);
            panel_top.Controls.Add(btnSearch);
            panel_top.Controls.Add(txtSearch);
            panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            panel_top.Location = new System.Drawing.Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new System.Drawing.Size(1171, 56);
            panel_top.TabIndex = 1;
            // 
            // sortList
            // 
            sortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            sortList.FormattingEnabled = true;
            sortList.Items.AddRange(new object[] { "Tất cả", "A-Z Tên", "Z-A Tên", "A-Z Email", "Z-A Email", "Nhân viên", "Khách hàng", "Hoạt động", "Vô hiệu hóa", "Hoạt động gần đây" });
            sortList.Location = new System.Drawing.Point(992, 12);
            sortList.Name = "sortList";
            sortList.Size = new System.Drawing.Size(167, 28);
            sortList.TabIndex = 2;
            sortList.SelectedIndexChanged += sortList_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.SystemColors.Window;
            btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            btnSearch.Image = (System.Drawing.Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new System.Drawing.Point(880, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(40, 27);
            btnSearch.TabIndex = 1;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Location = new System.Drawing.Point(327, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm...";
            txtSearch.Size = new System.Drawing.Size(547, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvAccount
            // 
            dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvAccount.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAccount.GridColor = System.Drawing.SystemColors.WindowFrame;
            dgvAccount.Location = new System.Drawing.Point(12, 26);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dgvAccount.RowHeadersVisible = false;
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.RowTemplate.Height = 29;
            dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAccount.Size = new System.Drawing.Size(1147, 386);
            dgvAccount.TabIndex = 0;
            dgvAccount.CellContentClick += dgvAccount_CellContentClick;
            // 
            // btnDetail
            // 
            btnDetail.Location = new System.Drawing.Point(937, 418);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new System.Drawing.Size(94, 29);
            btnDetail.TabIndex = 1;
            btnDetail.Text = "Chi tiết";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.SystemColors.Window;
            btnAdd.Location = new System.Drawing.Point(1037, 418);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(122, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm nhân viên";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(12, 418);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(292, 27);
            txtUsername.TabIndex = 3;
            txtUsername.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRef);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(dgvAccount);
            groupBox1.Controls.Add(btnDetail);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Location = new System.Drawing.Point(0, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1171, 453);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách tài khoản";
            // 
            // btnRef
            // 
            btnRef.Location = new System.Drawing.Point(786, 418);
            btnRef.Name = "btnRef";
            btnRef.Size = new System.Drawing.Size(145, 29);
            btnRef.TabIndex = 4;
            btnRef.Text = "Làm mới danh sách";
            btnRef.UseVisualStyleBackColor = true;
            btnRef.Click += btnRef_Click;
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1171, 514);
            Controls.Add(groupBox1);
            Controls.Add(panel_top);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AccountManagement";
            Text = "AccountManagement";
            Load += AccountManagement_Load;
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.ComboBox sortList;
    }
}