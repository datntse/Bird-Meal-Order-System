namespace ElectricStore_Datnt
{
	partial class Manager
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
			base.Dispose(disposing)namespace ElectricStore_TramLU
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
				txtSearch = new TextBox();
				btnSearch = new Button();
				dgvProductList = new DataGridView();
				label1 = new Label();
				label2 = new Label();
				btnRefresh = new Button();
				btnDelete = new Button();
				label3 = new Label();
				txtProductId = new TextBox();
				btnUpdate = new Button();
				txtProductCode = new TextBox();
				label4 = new Label();
				txtProductName = new TextBox();
				label5 = new Label();
				cbCategory = new ComboBox();
				label6 = new Label();
				btnAdd = new Button();
				txtPrice = new TextBox();
				label7 = new Label();
				((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
				SuspendLayout();
				// 
				// txtSearch
				// 
				txtSearch.Location = new Point(177, 108);
				txtSearch.Name = "txtSearch";
				txtSearch.Size = new Size(170, 27);
				txtSearch.TabIndex = 9;
				// 
				// btnSearch
				// 
				btnSearch.Location = new Point(366, 106);
				btnSearch.Name = "btnSearch";
				btnSearch.Size = new Size(94, 29);
				btnSearch.TabIndex = 8;
				btnSearch.Text = "Search";
				btnSearch.UseVisualStyleBackColor = true;
				btnSearch.Click += btnSearch_Click;
				// 
				// dgvProductList
				// 
				dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				dgvProductList.Location = new Point(66, 156);
				dgvProductList.MultiSelect = false;
				dgvProductList.Name = "dgvProductList";
				dgvProductList.RowHeadersWidth = 51;
				dgvProductList.RowTemplate.Height = 29;
				dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				dgvProductList.Size = new Size(913, 282);
				dgvProductList.TabIndex = 7;
				dgvProductList.CellContentDoubleClick += dgvProductList_CellContentDoubleClick;
				// 
				// label1
				// 
				label1.AutoSize = true;
				label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
				label1.Location = new Point(423, 26);
				label1.Name = "label1";
				label1.Size = new Size(199, 46);
				label1.TabIndex = 10;
				label1.Text = "PRODUCTS";
				// 
				// label2
				// 
				label2.AutoSize = true;
				label2.Location = new Point(66, 111);
				label2.Name = "label2";
				label2.Size = new Size(95, 20);
				label2.TabIndex = 11;
				label2.Text = "ProductCode";
				// 
				// btnRefresh
				// 
				btnRefresh.Location = new Point(476, 106);
				btnRefresh.Name = "btnRefresh";
				btnRefresh.Size = new Size(94, 29);
				btnRefresh.TabIndex = 12;
				btnRefresh.Text = "Refresh";
				btnRefresh.UseVisualStyleBackColor = true;
				btnRefresh.Click += btnRefresh_Click;
				// 
				// btnDelete
				// 
				btnDelete.Location = new Point(589, 620);
				btnDelete.Name = "btnDelete";
				btnDelete.Size = new Size(94, 29);
				btnDelete.TabIndex = 13;
				btnDelete.Text = "Delete";
				btnDelete.UseVisualStyleBackColor = true;
				btnDelete.Click += btnDelete_Click;
				// 
				// label3
				// 
				label3.AutoSize = true;
				label3.Location = new Point(66, 474);
				label3.Name = "label3";
				label3.Size = new Size(77, 20);
				label3.TabIndex = 14;
				label3.Text = "Product Id";
				// 
				// txtProductId
				// 
				txtProductId.Location = new Point(149, 471);
				txtProductId.Name = "txtProductId";
				txtProductId.Size = new Size(65, 27);
				txtProductId.TabIndex = 15;
				// 
				// btnUpdate
				// 
				btnUpdate.Location = new Point(466, 620);
				btnUpdate.Name = "btnUpdate";
				btnUpdate.Size = new Size(94, 29);
				btnUpdate.TabIndex = 16;
				btnUpdate.Text = "Update";
				btnUpdate.UseVisualStyleBackColor = true;
				btnUpdate.Click += btnUpdate_Click;
				// 
				// txtProductCode
				// 
				txtProductCode.Location = new Point(423, 471);
				txtProductCode.Name = "txtProductCode";
				txtProductCode.Size = new Size(125, 27);
				txtProductCode.TabIndex = 18;
				// 
				// label4
				// 
				label4.AutoSize = true;
				label4.Location = new Point(318, 474);
				label4.Name = "label4";
				label4.Size = new Size(99, 20);
				label4.TabIndex = 17;
				label4.Text = "Product Code";
				// 
				// txtProductName
				// 
				txtProductName.Location = new Point(177, 539);
				txtProductName.Name = "txtProductName";
				txtProductName.Size = new Size(222, 27);
				txtProductName.TabIndex = 20;
				// 
				// label5
				// 
				label5.AutoSize = true;
				label5.Location = new Point(72, 542);
				label5.Name = "label5";
				label5.Size = new Size(104, 20);
				label5.TabIndex = 19;
				label5.Text = "Product Name";
				// 
				// cbCategory
				// 
				cbCategory.FormattingEnabled = true;
				cbCategory.Location = new Point(653, 539);
				cbCategory.Name = "cbCategory";
				cbCategory.Size = new Size(205, 28);
				cbCategory.TabIndex = 22;
				// 
				// label6
				// 
				label6.AutoSize = true;
				label6.Location = new Point(534, 542);
				label6.Name = "label6";
				label6.Size = new Size(113, 20);
				label6.TabIndex = 21;
				label6.Text = "Category Name";
				// 
				// btnAdd
				// 
				btnAdd.Location = new Point(347, 620);
				btnAdd.Name = "btnAdd";
				btnAdd.Size = new Size(94, 29);
				btnAdd.TabIndex = 23;
				btnAdd.Text = "Add";
				btnAdd.UseVisualStyleBackColor = true;
				btnAdd.Click += btnAdd_Click;
				// 
				// txtPrice
				// 
				txtPrice.Location = new Point(733, 467);
				txtPrice.Name = "txtPrice";
				txtPrice.Size = new Size(154, 27);
				txtPrice.TabIndex = 25;
				// 
				// label7
				// 
				label7.AutoSize = true;
				label7.Location = new Point(680, 473);
				label7.Name = "label7";
				label7.Size = new Size(41, 20);
				label7.TabIndex = 24;
				label7.Text = "Price";
				// 
				// Management
				// 
				AutoScaleDimensions = new SizeF(8F, 20F);
				AutoScaleMode = AutoScaleMode.Font;
				ClientSize = new Size(1076, 716);
				Controls.Add(txtPrice);
				Controls.Add(label7);
				Controls.Add(btnAdd);
				Controls.Add(cbCategory);
				Controls.Add(label6);
				Controls.Add(txtProductName);
				Controls.Add(label5);
				Controls.Add(txtProductCode);
				Controls.Add(label4);
				Controls.Add(btnUpdate);
				Controls.Add(txtProductId);
				Controls.Add(label3);
				Controls.Add(btnDelete);
				Controls.Add(btnRefresh);
				Controls.Add(label2);
				Controls.Add(label1);
				Controls.Add(txtSearch);
				Controls.Add(btnSearch);
				Controls.Add(dgvProductList);
				Name = "Management";
				Text = "Managementcs";
				((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
				ResumeLayout(false);
				PerformLayout();
			}

			#endregion

			private TextBox txtSearch;
			private Button btnSearch;
			private DataGridView dgvProductList;
			private Label label1;
			private Label label2;
			private Button btnRefresh;
			private Button btnDelete;
			private Label label3;
			private TextBox txtProductId;
			private Button btnUpdate;
			private TextBox txtProductCode;
			private Label label4;
			private TextBox txtProductName;
			private Label label5;
			private ComboBox cbCategory;
			private Label label6;
			private Button btnAdd;
			private TextBox txtPrice;
			private Label label7;
		}
	}
}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			productDataView = new System.Windows.Forms.DataGridView();
			label1 = new System.Windows.Forms.Label();
			txtProductId = new System.Windows.Forms.TextBox();
			txtProductName = new System.Windows.Forms.TextBox();
			label2 = new System.Windows.Forms.Label();
			txtProductCode = new System.Windows.Forms.TextBox();
			label3 = new System.Windows.Forms.Label();
			txtProductPrice = new System.Windows.Forms.TextBox();
			label4 = new System.Windows.Forms.Label();
			txtDateCreate = new System.Windows.Forms.TextBox();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			createBtn = new System.Windows.Forms.Button();
			updateBtn = new System.Windows.Forms.Button();
			deleteBtn = new System.Windows.Forms.Button();
			label8 = new System.Windows.Forms.Label();
			txtSearchValue = new System.Windows.Forms.TextBox();
			searchBtn = new System.Windows.Forms.Button();
			resetBtn = new System.Windows.Forms.Button();
			cbCateName = new System.Windows.Forms.ComboBox();
			cbCateCode = new System.Windows.Forms.ComboBox();
			label9 = new System.Windows.Forms.Label();
			textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)productDataView).BeginInit();
			SuspendLayout();
			// 
			// productDataView
			// 
			productDataView.AllowUserToAddRows = false;
			productDataView.AllowUserToDeleteRows = false;
			productDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			productDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			productDataView.Location = new System.Drawing.Point(31, 93);
			productDataView.Name = "productDataView";
			productDataView.ReadOnly = true;
			productDataView.RowHeadersWidth = 62;
			productDataView.RowTemplate.Height = 33;
			productDataView.Size = new System.Drawing.Size(1012, 181);
			productDataView.TabIndex = 0;
			productDataView.CellContentDoubleClick += productDataView_CellContentDoubleClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(39, 294);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(95, 25);
			label1.TabIndex = 1;
			label1.Text = "productId:";
			// 
			// txtProductId
			// 
			txtProductId.Location = new System.Drawing.Point(206, 294);
			txtProductId.Name = "txtProductId";
			txtProductId.Size = new System.Drawing.Size(213, 31);
			txtProductId.TabIndex = 2;
			// 
			// txtProductName
			// 
			txtProductName.Location = new System.Drawing.Point(206, 331);
			txtProductName.Name = "txtProductName";
			txtProductName.Size = new System.Drawing.Size(213, 31);
			txtProductName.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(39, 331);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(128, 25);
			label2.TabIndex = 3;
			label2.Text = "product name:";
			// 
			// txtProductCode
			// 
			txtProductCode.Location = new System.Drawing.Point(206, 368);
			txtProductCode.Name = "txtProductCode";
			txtProductCode.Size = new System.Drawing.Size(213, 31);
			txtProductCode.TabIndex = 6;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(39, 368);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(123, 25);
			label3.TabIndex = 5;
			label3.Text = "product code:";
			// 
			// txtProductPrice
			// 
			txtProductPrice.Location = new System.Drawing.Point(206, 405);
			txtProductPrice.Name = "txtProductPrice";
			txtProductPrice.Size = new System.Drawing.Size(213, 31);
			txtProductPrice.TabIndex = 8;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(39, 405);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(54, 25);
			label4.TabIndex = 7;
			label4.Text = "price:";
			// 
			// txtDateCreate
			// 
			txtDateCreate.Location = new System.Drawing.Point(206, 442);
			txtDateCreate.Name = "txtDateCreate";
			txtDateCreate.Size = new System.Drawing.Size(213, 31);
			txtDateCreate.TabIndex = 10;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(39, 442);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(103, 25);
			label5.TabIndex = 9;
			label5.Text = "date create:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(39, 479);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(105, 25);
			label6.TabIndex = 11;
			label6.Text = "category id:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(39, 526);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(134, 25);
			label7.TabIndex = 13;
			label7.Text = "category name:";
			// 
			// createBtn
			// 
			createBtn.Location = new System.Drawing.Point(468, 294);
			createBtn.Name = "createBtn";
			createBtn.Size = new System.Drawing.Size(112, 34);
			createBtn.TabIndex = 15;
			createBtn.Text = "Create";
			createBtn.UseVisualStyleBackColor = true;
			createBtn.Click += createBtn_Click;
			// 
			// updateBtn
			// 
			updateBtn.Location = new System.Drawing.Point(468, 349);
			updateBtn.Name = "updateBtn";
			updateBtn.Size = new System.Drawing.Size(112, 34);
			updateBtn.TabIndex = 16;
			updateBtn.Text = "Update";
			updateBtn.UseVisualStyleBackColor = true;
			updateBtn.Click += updateBtn_Click;
			// 
			// deleteBtn
			// 
			deleteBtn.Location = new System.Drawing.Point(468, 405);
			deleteBtn.Name = "deleteBtn";
			deleteBtn.Size = new System.Drawing.Size(112, 34);
			deleteBtn.TabIndex = 17;
			deleteBtn.Text = "Delete";
			deleteBtn.UseVisualStyleBackColor = true;
			deleteBtn.Click += deleteBtn_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(31, 36);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(181, 25);
			label8.TabIndex = 18;
			label8.Text = "search product Code:";
			// 
			// txtSearchValue
			// 
			txtSearchValue.Location = new System.Drawing.Point(218, 30);
			txtSearchValue.Name = "txtSearchValue";
			txtSearchValue.Size = new System.Drawing.Size(213, 31);
			txtSearchValue.TabIndex = 19;
			// 
			// searchBtn
			// 
			searchBtn.Location = new System.Drawing.Point(448, 28);
			searchBtn.Name = "searchBtn";
			searchBtn.Size = new System.Drawing.Size(112, 34);
			searchBtn.TabIndex = 20;
			searchBtn.Text = "Search";
			searchBtn.UseVisualStyleBackColor = true;
			searchBtn.Click += searchBtn_Click;
			// 
			// resetBtn
			// 
			resetBtn.Location = new System.Drawing.Point(468, 460);
			resetBtn.Name = "resetBtn";
			resetBtn.Size = new System.Drawing.Size(112, 34);
			resetBtn.TabIndex = 21;
			resetBtn.Text = "Reset";
			resetBtn.UseVisualStyleBackColor = true;
			resetBtn.Click += resetBtn_Click;
			// 
			// cbCateName
			// 
			cbCateName.FormattingEnabled = true;
			cbCateName.Location = new System.Drawing.Point(206, 523);
			cbCateName.Name = "cbCateName";
			cbCateName.Size = new System.Drawing.Size(182, 33);
			cbCateName.TabIndex = 23;
			// 
			// cbCateCode
			// 
			cbCateCode.FormattingEnabled = true;
			cbCateCode.Location = new System.Drawing.Point(206, 569);
			cbCateCode.Name = "cbCateCode";
			cbCateCode.Size = new System.Drawing.Size(182, 33);
			cbCateCode.TabIndex = 25;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(39, 567);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(132, 25);
			label9.TabIndex = 24;
			label9.Text = "category Code:";
			// 
			// textBox1
			// 
			textBox1.Location = new System.Drawing.Point(206, 481);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(213, 31);
			textBox1.TabIndex = 26;
			// 
			// Manager
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1069, 690);
			Controls.Add(textBox1);
			Controls.Add(cbCateCode);
			Controls.Add(label9);
			Controls.Add(cbCateName);
			Controls.Add(resetBtn);
			Controls.Add(searchBtn);
			Controls.Add(txtSearchValue);
			Controls.Add(label8);
			Controls.Add(deleteBtn);
			Controls.Add(updateBtn);
			Controls.Add(createBtn);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(txtDateCreate);
			Controls.Add(label5);
			Controls.Add(txtProductPrice);
			Controls.Add(label4);
			Controls.Add(txtProductCode);
			Controls.Add(label3);
			Controls.Add(txtProductName);
			Controls.Add(label2);
			Controls.Add(txtProductId);
			Controls.Add(label1);
			Controls.Add(productDataView);
			Name = "Manager";
			Text = "Manager";
			Load += Manager_Load;
			((System.ComponentModel.ISupportInitialize)productDataView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.DataGridView productDataView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtProductId;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProductCode;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDateCreate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button createBtn;
		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtSearchValue;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.Button resetBtn;
		private System.Windows.Forms.ComboBox cbCateName;
		private System.Windows.Forms.ComboBox cbCateCode;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox1;
	}
}