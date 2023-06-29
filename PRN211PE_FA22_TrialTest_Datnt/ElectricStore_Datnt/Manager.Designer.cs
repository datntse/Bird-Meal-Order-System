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
			txtCategoryId = new System.Windows.Forms.TextBox();
			label6 = new System.Windows.Forms.Label();
			txtCategoryName = new System.Windows.Forms.TextBox();
			label7 = new System.Windows.Forms.Label();
			createBtn = new System.Windows.Forms.Button();
			updateBtn = new System.Windows.Forms.Button();
			deleteBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)productDataView).BeginInit();
			SuspendLayout();
			// 
			// productDataView
			// 
			productDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			productDataView.Location = new System.Drawing.Point(31, 50);
			productDataView.Name = "productDataView";
			productDataView.RowHeadersWidth = 62;
			productDataView.RowTemplate.Height = 33;
			productDataView.Size = new System.Drawing.Size(721, 224);
			productDataView.TabIndex = 0;
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
			// txtCategoryId
			// 
			txtCategoryId.Location = new System.Drawing.Point(206, 479);
			txtCategoryId.Name = "txtCategoryId";
			txtCategoryId.Size = new System.Drawing.Size(213, 31);
			txtCategoryId.TabIndex = 12;
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
			// txtCategoryName
			// 
			txtCategoryName.Location = new System.Drawing.Point(206, 516);
			txtCategoryName.Name = "txtCategoryName";
			txtCategoryName.Size = new System.Drawing.Size(213, 31);
			txtCategoryName.TabIndex = 14;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(39, 516);
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
			// Manager
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 591);
			Controls.Add(deleteBtn);
			Controls.Add(updateBtn);
			Controls.Add(createBtn);
			Controls.Add(txtCategoryName);
			Controls.Add(label7);
			Controls.Add(txtCategoryId);
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
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button createBtn;
		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Button deleteBtn;
	}
}