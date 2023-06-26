﻿namespace BMOSWinForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewProduct = new System.Windows.Forms.DataGridView();
            productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tblProductBindingSource = new System.Windows.Forms.BindingSource(components);
            label1 = new System.Windows.Forms.Label();
            txt_id = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txt_name = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txt_quantity = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txt_decription = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txt_weight = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txt_type = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            btn_save = new System.Windows.Forms.Button();
            btn_update = new System.Windows.Forms.Button();
            btn_delete = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            btn_viewproduct = new System.Windows.Forms.Button();
            btn_add = new System.Windows.Forms.Button();
            btn_detail = new System.Windows.Forms.Button();
            txt_price = new System.Windows.Forms.TextBox();
            lb_price = new System.Windows.Forms.Label();
            checkBox_status = new System.Windows.Forms.CheckBox();
            txt_search = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            btn_search = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblProductBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AllowUserToAddRows = false;
            dataGridViewProduct.AllowUserToDeleteRows = false;
            dataGridViewProduct.AutoGenerateColumns = false;
            dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, weightDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridViewProduct.DataSource = tblProductBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewProduct.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProduct.GridColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewProduct.Location = new System.Drawing.Point(12, 71);
            dataGridViewProduct.MultiSelect = false;
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.RowHeadersWidth = 51;
            dataGridViewProduct.RowTemplate.Height = 29;
            dataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduct.Size = new System.Drawing.Size(1142, 260);
            dataGridViewProduct.TabIndex = 0;
            dataGridViewProduct.CellClick += dataGridViewProduct_CellContentClick;
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
            // tblProductBindingSource
            // 
            tblProductBindingSource.DataSource = typeof(Repository.Models.Entities.TblProduct);
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
            // txt_id
            // 
            txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_id.Location = new System.Drawing.Point(153, 28);
            txt_id.Name = "txt_id";
            txt_id.Size = new System.Drawing.Size(375, 27);
            txt_id.TabIndex = 1;
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
            // txt_name
            // 
            txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_name.Location = new System.Drawing.Point(153, 61);
            txt_name.Name = "txt_name";
            txt_name.Size = new System.Drawing.Size(375, 27);
            txt_name.TabIndex = 3;
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
            // txt_quantity
            // 
            txt_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_quantity.Location = new System.Drawing.Point(153, 94);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new System.Drawing.Size(375, 27);
            txt_quantity.TabIndex = 5;
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
            // txt_decription
            // 
            txt_decription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_decription.Location = new System.Drawing.Point(734, 31);
            txt_decription.Name = "txt_decription";
            txt_decription.Size = new System.Drawing.Size(289, 27);
            txt_decription.TabIndex = 7;
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
            // txt_weight
            // 
            txt_weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_weight.Location = new System.Drawing.Point(734, 64);
            txt_weight.Name = "txt_weight";
            txt_weight.Size = new System.Drawing.Size(375, 27);
            txt_weight.TabIndex = 9;
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
            // txt_type
            // 
            txt_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_type.Location = new System.Drawing.Point(734, 97);
            txt_type.Name = "txt_type";
            txt_type.Size = new System.Drawing.Size(375, 27);
            txt_type.TabIndex = 11;
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
            // panel1
            // 
            panel1.Controls.Add(btn_viewproduct);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(btn_detail);
            panel1.Controls.Add(txt_price);
            panel1.Controls.Add(lb_price);
            panel1.Controls.Add(checkBox_status);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_type);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_weight);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_decription);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_quantity);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(12, 337);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1142, 206);
            panel1.TabIndex = 1;
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
            // txt_search
            // 
            txt_search.Location = new System.Drawing.Point(144, 12);
            txt_search.Name = "txt_search";
            txt_search.Size = new System.Drawing.Size(459, 27);
            txt_search.TabIndex = 2;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(68, 15);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 20);
            label5.TabIndex = 3;
            label5.Text = "Tìm kiếm";
            // 
            // btn_search
            // 
            btn_search.Location = new System.Drawing.Point(611, 12);
            btn_search.Name = "btn_search";
            btn_search.Size = new System.Drawing.Size(75, 29);
            btn_search.TabIndex = 21;
            btn_search.Text = "Tìm";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sản phẩm còn hàng", "Sản phẩm hết hàng", "Tất cả sản phẩm", "A-Z", "Thức ăn hạt", "Thức ăn tự nhiên", "Thức ăn hỗn hợp" });
            comboBox1.Location = new System.Drawing.Point(692, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(151, 28);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1196, 565);
            Controls.Add(comboBox1);
            Controls.Add(btn_search);
            Controls.Add(label5);
            Controls.Add(txt_search);
            Controls.Add(panel1);
            Controls.Add(dataGridViewProduct);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ProductManagement";
            Text = "ProductManagement";
            Load += ProductManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblProductBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_decription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_status;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_viewproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}