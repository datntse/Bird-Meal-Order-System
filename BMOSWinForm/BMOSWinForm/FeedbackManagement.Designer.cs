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
            label2 = new System.Windows.Forms.Label();
            txt_id = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            btndelete = new System.Windows.Forms.Button();
            dgvFeedbackList = new System.Windows.Forms.DataGridView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btrs = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            searchBtn = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            txtdetails = new System.Windows.Forms.Button();
            mafb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            star = new System.Windows.Forms.DataGridViewTextBoxColumn();
            date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFeedbackList).BeginInit();
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
            txt_id.Size = new System.Drawing.Size(97, 27);
            txt_id.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(816, 508);
            button3.Margin = new System.Windows.Forms.Padding(2);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(90, 49);
            button3.TabIndex = 10;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new System.Drawing.Point(229, 514);
            btndelete.Margin = new System.Windows.Forms.Padding(2);
            btndelete.Name = "btndelete";
            btndelete.Size = new System.Drawing.Size(94, 37);
            btndelete.TabIndex = 7;
            btndelete.Text = "del";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // dgvFeedbackList
            // 
            dgvFeedbackList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvFeedbackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeedbackList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { mafb, masp, name, content, star, date });
            dgvFeedbackList.Location = new System.Drawing.Point(11, 90);
            dgvFeedbackList.Margin = new System.Windows.Forms.Padding(2);
            dgvFeedbackList.Name = "dgvFeedbackList";
            dgvFeedbackList.RowHeadersWidth = 62;
            dgvFeedbackList.RowTemplate.Height = 33;
            dgvFeedbackList.Size = new System.Drawing.Size(895, 383);
            dgvFeedbackList.TabIndex = 6;
            dgvFeedbackList.CellContentClick += dgvFeedbackList_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btrs);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(searchBtn);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Location = new System.Drawing.Point(11, 16);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(895, 70);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manage Feedback";
            // 
            // btrs
            // 
            btrs.Location = new System.Drawing.Point(769, 16);
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
            searchBtn.Location = new System.Drawing.Point(652, 16);
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
            txtdetails.Location = new System.Drawing.Point(116, 514);
            txtdetails.Name = "txtdetails";
            txtdetails.Size = new System.Drawing.Size(94, 38);
            txtdetails.TabIndex = 11;
            txtdetails.Text = "Chi Tiết";
            txtdetails.UseVisualStyleBackColor = true;
            txtdetails.Click += txtdetails_Click;
            // 
            // mafb
            // 
            mafb.DataPropertyName = "idfb";
            mafb.HeaderText = "Mã Feedback";
            mafb.MinimumWidth = 6;
            mafb.Name = "mafb";
            // 
            // masp
            // 
            masp.DataPropertyName = "idpro";
            masp.HeaderText = "Mã sản phẩm";
            masp.MinimumWidth = 6;
            masp.Name = "masp";
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Tên sản phẩm";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // content
            // 
            content.DataPropertyName = "content";
            content.HeaderText = "Đánh giá";
            content.MinimumWidth = 6;
            content.Name = "content";
            // 
            // star
            // 
            star.DataPropertyName = "star";
            star.HeaderText = "Sao";
            star.MinimumWidth = 6;
            star.Name = "star";
            // 
            // date
            // 
            date.DataPropertyName = "date";
            date.HeaderText = "Thời gian";
            date.MinimumWidth = 6;
            date.Name = "date";
            // 
            // FeedbackManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(910, 595);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn mafb;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn star;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}