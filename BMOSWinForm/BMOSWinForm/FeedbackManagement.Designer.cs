namespace BMOSWinForm
{
    partial class FeedbackManagement
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
            label2 = new System.Windows.Forms.Label();
            txt_id = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            btndelete = new System.Windows.Forms.Button();
            dgvFeedbackList = new System.Windows.Forms.DataGridView();
            idfb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idpro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            star = new System.Windows.Forms.DataGridViewTextBoxColumn();
            date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tblFeedbackBindingSource1 = new System.Windows.Forms.BindingSource(components);
            tblFeedbackBindingSource = new System.Windows.Forms.BindingSource(components);
            groupBox1 = new System.Windows.Forms.GroupBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            btrs = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            searchBtn = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            txtdetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvFeedbackList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblFeedbackBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblFeedbackBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 496);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 20);
            label2.TabIndex = 8;
            label2.Text = "Mã Feedback:";
            // 
            // txt_id
            // 
            txt_id.Location = new System.Drawing.Point(11, 520);
            txt_id.Margin = new System.Windows.Forms.Padding(2);
            txt_id.Name = "txt_id";
            txt_id.Size = new System.Drawing.Size(132, 27);
            txt_id.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(941, 508);
            button3.Margin = new System.Windows.Forms.Padding(2);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(124, 49);
            button3.TabIndex = 10;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new System.Drawing.Point(303, 515);
            btndelete.Margin = new System.Windows.Forms.Padding(2);
            btndelete.Name = "btndelete";
            btndelete.Size = new System.Drawing.Size(118, 37);
            btndelete.TabIndex = 7;
            btndelete.Text = "Xóa";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // dgvFeedbackList
            // 
            dgvFeedbackList.AllowUserToAddRows = false;
            dgvFeedbackList.AllowUserToDeleteRows = false;
            dgvFeedbackList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvFeedbackList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvFeedbackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeedbackList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idfb, idpro, name, content, star, date });
            dgvFeedbackList.Location = new System.Drawing.Point(11, 99);
            dgvFeedbackList.Margin = new System.Windows.Forms.Padding(2);
            dgvFeedbackList.Name = "dgvFeedbackList";
            dgvFeedbackList.ReadOnly = true;
            dgvFeedbackList.RowHeadersWidth = 62;
            dgvFeedbackList.RowTemplate.Height = 33;
            dgvFeedbackList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvFeedbackList.Size = new System.Drawing.Size(1054, 383);
            dgvFeedbackList.TabIndex = 6;
            dgvFeedbackList.CellContentClick += dgvFeedbackList_CellContentClick;
            // 
            // idfb
            // 
            idfb.DataPropertyName = "idfb";
            idfb.FillWeight = 40F;
            idfb.HeaderText = "ID Feedback";
            idfb.MinimumWidth = 6;
            idfb.Name = "idfb";
            idfb.ReadOnly = true;
            // 
            // idpro
            // 
            idpro.DataPropertyName = "idpro";
            idpro.FillWeight = 40F;
            idpro.HeaderText = "ID sản phẩm";
            idpro.MinimumWidth = 6;
            idpro.Name = "idpro";
            idpro.ReadOnly = true;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Tên sản phẩm";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // content
            // 
            content.DataPropertyName = "content";
            content.FillWeight = 150F;
            content.HeaderText = "Nội dung đánh giá";
            content.MinimumWidth = 6;
            content.Name = "content";
            content.ReadOnly = true;
            // 
            // star
            // 
            star.DataPropertyName = "star";
            star.FillWeight = 30F;
            star.HeaderText = "Sao";
            star.MinimumWidth = 6;
            star.Name = "star";
            star.ReadOnly = true;
            // 
            // date
            // 
            date.DataPropertyName = "date";
            date.FillWeight = 80F;
            date.HeaderText = "Thời gian";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // tblFeedbackBindingSource1
            // 
            tblFeedbackBindingSource1.DataSource = typeof(Repository.Models.Entities.TblFeedback);
            // 
            // tblFeedbackBindingSource
            // 
            tblFeedbackBindingSource.DataSource = typeof(Repository.Models.Entities.TblFeedback);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btrs);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(searchBtn);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Location = new System.Drawing.Point(11, 16);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(1054, 70);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manage Feedback";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tất cả sản phẩm", "A-Z", "Z-A", "Số sao tăng dần", "Số sao giảm dần" });
            comboBox1.Location = new System.Drawing.Point(654, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(151, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btrs
            // 
            btrs.Location = new System.Drawing.Point(941, 14);
            btrs.Name = "btrs";
            btrs.Size = new System.Drawing.Size(96, 50);
            btrs.TabIndex = 3;
            btrs.Text = "Làm mới";
            btrs.UseVisualStyleBackColor = true;
            btrs.Click += btrs_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 29);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 20);
            label1.TabIndex = 2;
            label1.Text = "Từ khóa";
            // 
            // searchBtn
            // 
            searchBtn.Location = new System.Drawing.Point(825, 15);
            searchBtn.Margin = new System.Windows.Forms.Padding(2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new System.Drawing.Size(99, 50);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Tìm kiếm";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(118, 27);
            txtSearch.Margin = new System.Windows.Forms.Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(516, 27);
            txtSearch.TabIndex = 0;
            // 
            // txtdetails
            // 
            txtdetails.Location = new System.Drawing.Point(164, 514);
            txtdetails.Name = "txtdetails";
            txtdetails.Size = new System.Drawing.Size(122, 38);
            txtdetails.TabIndex = 11;
            txtdetails.Text = "Chi Tiết";
            txtdetails.UseVisualStyleBackColor = true;
            txtdetails.Click += txtdetails_Click;
            // 
            // FeedbackManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1178, 592);
            Controls.Add(txtdetails);
            Controls.Add(label2);
            Controls.Add(txt_id);
            Controls.Add(button3);
            Controls.Add(btndelete);
            Controls.Add(dgvFeedbackList);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FeedbackManagement";
            Text = "FeedbackManagement";
            Load += FeedbackManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFeedbackList).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblFeedbackBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblFeedbackBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dgvFeedbackList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRs;
        private System.Windows.Forms.Button btrs;
        private System.Windows.Forms.Button txtdetails;
        private System.Windows.Forms.BindingSource tblFeedbackBindingSource;
        private System.Windows.Forms.BindingSource tblFeedbackBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn star;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}