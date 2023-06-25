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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManagement));
            panel_body = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnDetail = new System.Windows.Forms.Button();
            dgvAccount = new System.Windows.Forms.DataGridView();
            panel_top = new System.Windows.Forms.Panel();
            btnSearch = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            panel_top.SuspendLayout();
            SuspendLayout();
            // 
            // panel_body
            // 
            panel_body.BackColor = System.Drawing.SystemColors.Control;
            panel_body.Controls.Add(btnAdd);
            panel_body.Controls.Add(btnDetail);
            panel_body.Controls.Add(dgvAccount);
            panel_body.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_body.Location = new System.Drawing.Point(0, 82);
            panel_body.Name = "panel_body";
            panel_body.Size = new System.Drawing.Size(1171, 432);
            panel_body.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 20);
            label1.TabIndex = 2;
            label1.Text = "Danh sách tài khoản";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.SystemColors.Window;
            btnAdd.Location = new System.Drawing.Point(1037, 391);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(122, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm nhân viên";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDetail
            // 
            btnDetail.Location = new System.Drawing.Point(937, 391);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new System.Drawing.Size(94, 29);
            btnDetail.TabIndex = 1;
            btnDetail.Text = "Chi tiết";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
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
            dgvAccount.Location = new System.Drawing.Point(12, 3);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.RowTemplate.Height = 29;
            dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAccount.Size = new System.Drawing.Size(1147, 382);
            dgvAccount.TabIndex = 0;
            // 
            // panel_top
            // 
            panel_top.Controls.Add(btnSearch);
            panel_top.Controls.Add(txtSearch);
            panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            panel_top.Location = new System.Drawing.Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new System.Drawing.Size(1171, 56);
            panel_top.TabIndex = 1;
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
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Location = new System.Drawing.Point(327, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm...";
            txtSearch.Size = new System.Drawing.Size(547, 27);
            txtSearch.TabIndex = 0;
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1171, 514);
            Controls.Add(label1);
            Controls.Add(panel_top);
            Controls.Add(panel_body);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AccountManagement";
            Text = "AccountManagement";
            panel_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDetail;
    }
}