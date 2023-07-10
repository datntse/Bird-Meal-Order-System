namespace BMOSWinForm
{
    partial class ProductManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            tblProductBindingSource = new System.Windows.Forms.BindingSource(components);
            panel_body = new System.Windows.Forms.Panel();
            comboBox1 = new System.Windows.Forms.ComboBox();
            dataGridViewProduct = new System.Windows.Forms.DataGridView();
            productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2 = new System.Windows.Forms.Panel();
            btn_viewproduct = new System.Windows.Forms.Button();
            btn_add = new System.Windows.Forms.Button();
            btn_detail = new System.Windows.Forms.Button();
            txt_price = new System.Windows.Forms.TextBox();
            lb_price = new System.Windows.Forms.Label();
            checkBox_status = new System.Windows.Forms.CheckBox();
            btn_delete = new System.Windows.Forms.Button();
            btn_update = new System.Windows.Forms.Button();
            btn_save = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            txt_type = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txt_weight = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txt_decription = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txt_quantity = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txt_name = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txt_id = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txt_search = new System.Windows.Forms.TextBox();
            panel_control = new System.Windows.Forms.Panel();
            btnHome = new System.Windows.Forms.Button();
            btnProduct = new System.Windows.Forms.Button();
            btnFeedback = new System.Windows.Forms.Button();
            btnBlog = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            btnOrder = new System.Windows.Forms.Button();
            btnAcc = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label9 = new System.Windows.Forms.Label();
            txtTitle = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)tblProductBindingSource).BeginInit();
            panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            panel2.SuspendLayout();
            panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tblProductBindingSource
            // 
            tblProductBindingSource.DataSource = typeof(Repository.Models.Entities.TblProduct);
            // 
            // panel_body
            // 
            panel_body.Controls.Add(label10);
            panel_body.Controls.Add(comboBox1);
            panel_body.Controls.Add(dataGridViewProduct);
            panel_body.Controls.Add(panel2);
            panel_body.Controls.Add(label5);
            panel_body.Controls.Add(txt_search);
            panel_body.Location = new System.Drawing.Point(332, 92);
            panel_body.Name = "panel_body";
            panel_body.Size = new System.Drawing.Size(1171, 561);
            panel_body.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sản phẩm còn hàng", "Sản phẩm hết hàng", "Tất cả sản phẩm", "A-Z", "Thức ăn hạt", "Thức ăn tự nhiên", "Thức ăn hỗn hợp" });
            comboBox1.Location = new System.Drawing.Point(653, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(234, 28);
            comboBox1.TabIndex = 28;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AllowUserToAddRows = false;
            dataGridViewProduct.AllowUserToDeleteRows = false;
            dataGridViewProduct.AllowUserToOrderColumns = true;
            dataGridViewProduct.AutoGenerateColumns = false;
            dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, weightDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridViewProduct.DataSource = tblProductBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewProduct.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewProduct.GridColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewProduct.Location = new System.Drawing.Point(16, 76);
            dataGridViewProduct.MultiSelect = false;
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.RowHeadersWidth = 51;
            dataGridViewProduct.RowTemplate.Height = 29;
            dataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduct.Size = new System.Drawing.Size(1142, 260);
            dataGridViewProduct.TabIndex = 23;
            dataGridViewProduct.CellContentClick += dataGridViewProduct_CellContentClick;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            weightDataGridViewTextBoxColumn.MinimumWidth = 6;
            weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_viewproduct);
            panel2.Controls.Add(btn_add);
            panel2.Controls.Add(btn_detail);
            panel2.Controls.Add(txt_price);
            panel2.Controls.Add(lb_price);
            panel2.Controls.Add(checkBox_status);
            panel2.Controls.Add(btn_delete);
            panel2.Controls.Add(btn_update);
            panel2.Controls.Add(btn_save);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_type);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_weight);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txt_decription);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_quantity);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_name);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_id);
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(16, 342);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1142, 206);
            panel2.TabIndex = 24;
            // 
            // btn_viewproduct
            // 
            btn_viewproduct.Location = new System.Drawing.Point(457, 171);
            btn_viewproduct.Name = "btn_viewproduct";
            btn_viewproduct.Size = new System.Drawing.Size(94, 29);
            btn_viewproduct.TabIndex = 24;
            btn_viewproduct.Text = "Chi tiết";
            btn_viewproduct.UseVisualStyleBackColor = true;
            btn_viewproduct.Click += btn_viewproduct_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new System.Drawing.Point(357, 171);
            btn_add.Name = "btn_add";
            btn_add.Size = new System.Drawing.Size(94, 29);
            btn_add.TabIndex = 23;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_detail
            // 
            btn_detail.Location = new System.Drawing.Point(1034, 31);
            btn_detail.Name = "btn_detail";
            btn_detail.Size = new System.Drawing.Size(75, 29);
            btn_detail.TabIndex = 20;
            btn_detail.Text = "Xem";
            btn_detail.UseVisualStyleBackColor = true;
            btn_detail.Click += btn_detail_Click;
            // 
            // txt_price
            // 
            txt_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_price.Location = new System.Drawing.Point(153, 127);
            txt_price.Name = "txt_price";
            txt_price.Size = new System.Drawing.Size(375, 27);
            txt_price.TabIndex = 19;
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.Location = new System.Drawing.Point(56, 130);
            lb_price.Name = "lb_price";
            lb_price.Size = new System.Drawing.Size(31, 20);
            lb_price.TabIndex = 18;
            lb_price.Text = "Giá";
            // 
            // checkBox_status
            // 
            checkBox_status.AutoSize = true;
            checkBox_status.Location = new System.Drawing.Point(734, 136);
            checkBox_status.Name = "checkBox_status";
            checkBox_status.Size = new System.Drawing.Size(18, 17);
            checkBox_status.TabIndex = 17;
            checkBox_status.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Enabled = false;
            btn_delete.Location = new System.Drawing.Point(257, 171);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new System.Drawing.Size(94, 29);
            btn_delete.TabIndex = 16;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Enabled = false;
            btn_update.Location = new System.Drawing.Point(157, 171);
            btn_update.Name = "btn_update";
            btn_update.Size = new System.Drawing.Size(94, 29);
            btn_update.TabIndex = 15;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new System.Drawing.Point(57, 171);
            btn_save.Name = "btn_save";
            btn_save.Size = new System.Drawing.Size(94, 29);
            btn_save.TabIndex = 14;
            btn_save.Text = "Lưu";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(637, 133);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(72, 20);
            label6.TabIndex = 12;
            label6.Text = "Còn hàng";
            // 
            // txt_type
            // 
            txt_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_type.Location = new System.Drawing.Point(734, 97);
            txt_type.Name = "txt_type";
            txt_type.Size = new System.Drawing.Size(375, 27);
            txt_type.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(637, 100);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(37, 20);
            label7.TabIndex = 10;
            label7.Text = "Loại";
            // 
            // txt_weight
            // 
            txt_weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_weight.Location = new System.Drawing.Point(734, 64);
            txt_weight.Name = "txt_weight";
            txt_weight.Size = new System.Drawing.Size(375, 27);
            txt_weight.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(637, 67);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 20);
            label8.TabIndex = 8;
            label8.Text = "Cân Nặng";
            // 
            // txt_decription
            // 
            txt_decription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_decription.Location = new System.Drawing.Point(734, 31);
            txt_decription.Name = "txt_decription";
            txt_decription.Size = new System.Drawing.Size(289, 27);
            txt_decription.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(637, 34);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Thông tin";
            // 
            // txt_quantity
            // 
            txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_quantity.Location = new System.Drawing.Point(153, 94);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new System.Drawing.Size(375, 27);
            txt_quantity.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(56, 97);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 20);
            label4.TabIndex = 4;
            label4.Text = "Số lượng";
            // 
            // txt_name
            // 
            txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_name.Location = new System.Drawing.Point(153, 61);
            txt_name.Name = "txt_name";
            txt_name.Size = new System.Drawing.Size(375, 27);
            txt_name.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(56, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // txt_id
            // 
            txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_id.Location = new System.Drawing.Point(153, 28);
            txt_id.Name = "txt_id";
            txt_id.Size = new System.Drawing.Size(375, 27);
            txt_id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(56, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Số";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(72, 20);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 20);
            label5.TabIndex = 26;
            label5.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            txt_search.Location = new System.Drawing.Point(148, 17);
            txt_search.Name = "txt_search";
            txt_search.Size = new System.Drawing.Size(459, 27);
            txt_search.TabIndex = 25;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // panel_control
            // 
            panel_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel_control.BackColor = System.Drawing.SystemColors.Desktop;
            panel_control.Controls.Add(btnHome);
            panel_control.Controls.Add(btnProduct);
            panel_control.Controls.Add(btnFeedback);
            panel_control.Controls.Add(btnBlog);
            panel_control.Controls.Add(btnLogout);
            panel_control.Controls.Add(btnOrder);
            panel_control.Controls.Add(btnAcc);
            panel_control.Controls.Add(pictureBox1);
            panel_control.Controls.Add(label9);
            panel_control.Location = new System.Drawing.Point(0, 0);
            panel_control.Name = "panel_control";
            panel_control.Size = new System.Drawing.Size(326, 653);
            panel_control.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = System.Drawing.SystemColors.GrayText;
            btnHome.Enabled = false;
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
            // 
            // btnProduct
            // 
            btnProduct.BackColor = System.Drawing.Color.Chocolate;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnProduct.Image = Properties.Resources.bird;
            btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProduct.Location = new System.Drawing.Point(0, 198);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            btnProduct.Size = new System.Drawing.Size(326, 55);
            btnProduct.TabIndex = 5;
            btnProduct.Text = "   Quản lý sản phẩm";
            btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFeedback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFeedback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnFeedback.Image = Properties.Resources.feedback__2_;
            btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFeedback.Location = new System.Drawing.Point(0, 354);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            btnFeedback.Size = new System.Drawing.Size(326, 55);
            btnFeedback.TabIndex = 5;
            btnFeedback.Text = "   Quản lý đánh giá";
            btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += btnFeedback_Click_1;
            // 
            // btnBlog
            // 
            btnBlog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnBlog.FlatAppearance.BorderSize = 0;
            btnBlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBlog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBlog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnBlog.Image = Properties.Resources.blogging;
            btnBlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBlog.Location = new System.Drawing.Point(0, 302);
            btnBlog.Name = "btnBlog";
            btnBlog.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            btnBlog.Size = new System.Drawing.Size(326, 55);
            btnBlog.TabIndex = 5;
            btnBlog.Text = "   Quản lý blog";
            btnBlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBlog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnBlog.UseVisualStyleBackColor = false;
            btnBlog.Click += btnBlog_Click_1;
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
            btnLogout.Location = new System.Drawing.Point(0, 584);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            btnLogout.Size = new System.Drawing.Size(326, 69);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "   Đăng xuất";
            btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnOrder.Image = Properties.Resources.shopping_bag;
            btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOrder.Location = new System.Drawing.Point(0, 250);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            btnOrder.Size = new System.Drawing.Size(326, 55);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "   Quản lý đơn hàng";
            btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click_1;
            // 
            // btnAcc
            // 
            btnAcc.BackColor = System.Drawing.SystemColors.GrayText;
            btnAcc.Enabled = false;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label9.Location = new System.Drawing.Point(75, 35);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(232, 33);
            label9.TabIndex = 0;
            label9.Text = "Bảng điều khiển";
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.BackColor = System.Drawing.Color.Chocolate;
            txtTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtTitle.Location = new System.Drawing.Point(805, 9);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(309, 46);
            txtTitle.TabIndex = 2;
            txtTitle.Text = "Quản lý Sản Phẩm";
            txtTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(613, 20);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(32, 20);
            label10.TabIndex = 29;
            label10.Text = "Lọc";
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1497, 653);
            Controls.Add(txtTitle);
            Controls.Add(panel_control);
            Controls.Add(panel_body);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ProductManagement";
            Text = "ProductManagement";
            Load += ProductManagement_Load;
            ((System.ComponentModel.ISupportInitialize)tblProductBindingSource).EndInit();
            panel_body.ResumeLayout(false);
            panel_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_control.ResumeLayout(false);
            panel_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_viewproduct;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.CheckBox checkBox_status;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_decription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnBlog;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label label10;
    }
}