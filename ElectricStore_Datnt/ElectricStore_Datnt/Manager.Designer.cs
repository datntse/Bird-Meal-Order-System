using System;
using System.Drawing;
using System.Windows.Forms;

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
			searchBtn = new Button();
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
			txtSearch.Location = new Point(221, 135);
			txtSearch.Margin = new Padding(4);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(212, 31);
			txtSearch.TabIndex = 9;
			// 
			// searchBtn
			// 
			searchBtn.Location = new Point(458, 132);
			searchBtn.Margin = new Padding(4);
			searchBtn.Name = "searchBtn";
			searchBtn.Size = new Size(118, 36);
			searchBtn.TabIndex = 8;
			searchBtn.Text = "Search";
			searchBtn.UseVisualStyleBackColor = true;
			searchBtn.Click += btnSearch_Click;
			// 
			// dgvProductList
			// 
			dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProductList.Location = new Point(82, 195);
			dgvProductList.Margin = new Padding(4);
			dgvProductList.MultiSelect = false;
			dgvProductList.Name = "dgvProductList";
			dgvProductList.RowHeadersWidth = 51;
			dgvProductList.RowTemplate.Height = 29;
			dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProductList.Size = new Size(1141, 352);
			dgvProductList.TabIndex = 7;
			dgvProductList.CellContentDoubleClick += dgvProductList_CellContentDoubleClick;
			dgvProductList.CellMouseDoubleClick += dgvProductList_CellMouseDoubleClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(82, 41);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(233, 54);
			label1.TabIndex = 10;
			label1.Text = "PRODUCTS";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(82, 139);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(116, 25);
			label2.TabIndex = 11;
			label2.Text = "ProductCode";
			// 
			// btnRefresh
			// 
			btnRefresh.Location = new Point(540, 762);
			btnRefresh.Margin = new Padding(4);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(118, 36);
			btnRefresh.TabIndex = 12;
			btnRefresh.Text = "Refresh";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(540, 703);
			btnDelete.Margin = new Padding(4);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(118, 36);
			btnDelete.TabIndex = 13;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(82, 576);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(95, 25);
			label3.TabIndex = 14;
			label3.Text = "Product Id";
			// 
			// txtProductId
			// 
			txtProductId.Location = new Point(221, 570);
			txtProductId.Margin = new Padding(4);
			txtProductId.Name = "txtProductId";
			txtProductId.Size = new Size(276, 31);
			txtProductId.TabIndex = 15;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(540, 639);
			btnUpdate.Margin = new Padding(4);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(118, 36);
			btnUpdate.TabIndex = 16;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// txtProductCode
			// 
			txtProductCode.Location = new Point(221, 616);
			txtProductCode.Margin = new Padding(4);
			txtProductCode.Name = "txtProductCode";
			txtProductCode.Size = new Size(276, 31);
			txtProductCode.TabIndex = 18;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(82, 619);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(121, 25);
			label4.TabIndex = 17;
			label4.Text = "Product Code";
			// 
			// txtProductName
			// 
			txtProductName.Location = new Point(221, 672);
			txtProductName.Margin = new Padding(4);
			txtProductName.Name = "txtProductName";
			txtProductName.Size = new Size(276, 31);
			txtProductName.TabIndex = 20;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(82, 678);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(126, 25);
			label5.TabIndex = 19;
			label5.Text = "Product Name";
			// 
			// cbCategory
			// 
			cbCategory.FormattingEnabled = true;
			cbCategory.Location = new Point(221, 778);
			cbCategory.Margin = new Padding(4);
			cbCategory.Name = "cbCategory";
			cbCategory.Size = new Size(276, 33);
			cbCategory.TabIndex = 22;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(82, 786);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(136, 25);
			label6.TabIndex = 21;
			label6.Text = "Category Name";
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(540, 576);
			btnAdd.Margin = new Padding(4);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(118, 36);
			btnAdd.TabIndex = 23;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// txtPrice
			// 
			txtPrice.Location = new Point(221, 727);
			txtPrice.Margin = new Padding(4);
			txtPrice.Name = "txtPrice";
			txtPrice.Size = new Size(276, 31);
			txtPrice.TabIndex = 25;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(82, 733);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(49, 25);
			label7.TabIndex = 24;
			label7.Text = "Price";
			// 
			// Manager
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1345, 895);
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
			Controls.Add(searchBtn);
			Controls.Add(dgvProductList);
			Margin = new Padding(4);
			Name = "Manager";
			Text = "Managementcs";
			((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}





		#endregion

		private TextBox txtSearch;
		private Button searchBtn;
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