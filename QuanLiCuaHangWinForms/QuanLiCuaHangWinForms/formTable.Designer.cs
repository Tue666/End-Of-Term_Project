namespace QuanLiCuaHangWinForms
{
    partial class formTable
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
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbFood = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.nmQuantityFood = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbSearchedItem = new System.Windows.Forms.ComboBox();
            this.txbSelectedItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.lsvBillInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPay = new System.Windows.Forms.Button();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSinglePrice = new System.Windows.Forms.TextBox();
            this.txbFocusTable = new System.Windows.Forms.TextBox();
            this.cbTableList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSwapTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantityFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(407, 62);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(104, 23);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbFood
            // 
            this.cbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(517, 62);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(189, 23);
            this.cbFood.TabIndex = 3;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(408, 45);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(64, 15);
            this.lbCategory.TabIndex = 4;
            this.lbCategory.Text = "Danh mục";
            // 
            // lbFood
            // 
            this.lbFood.AutoSize = true;
            this.lbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFood.Location = new System.Drawing.Point(523, 46);
            this.lbFood.Name = "lbFood";
            this.lbFood.Size = new System.Drawing.Size(64, 15);
            this.lbFood.TabIndex = 5;
            this.lbFood.Text = "Sản phẩm";
            // 
            // btnAddFood
            // 
            this.btnAddFood.AutoSize = true;
            this.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(698, 144);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(60, 44);
            this.btnAddFood.TabIndex = 6;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // nmQuantityFood
            // 
            this.nmQuantityFood.Location = new System.Drawing.Point(648, 162);
            this.nmQuantityFood.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmQuantityFood.Name = "nmQuantityFood";
            this.nmQuantityFood.Size = new System.Drawing.Size(44, 20);
            this.nmQuantityFood.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tìm kiếm theo danh mục:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tìm kiếm theo từ khóa:";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(573, 87);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(133, 21);
            this.txbSearch.TabIndex = 11;
            // 
            // btnFind
            // 
            this.btnFind.AutoSize = true;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(712, 85);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(46, 27);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // cbSearchedItem
            // 
            this.cbSearchedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchedItem.FormattingEnabled = true;
            this.cbSearchedItem.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbSearchedItem.Location = new System.Drawing.Point(473, 113);
            this.cbSearchedItem.Name = "cbSearchedItem";
            this.cbSearchedItem.Size = new System.Drawing.Size(233, 23);
            this.cbSearchedItem.TabIndex = 13;
            this.cbSearchedItem.SelectedIndexChanged += new System.EventHandler(this.cbSearchedItem_SelectedIndexChanged);
            // 
            // txbSelectedItem
            // 
            this.txbSelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSelectedItem.Location = new System.Drawing.Point(407, 163);
            this.txbSelectedItem.Name = "txbSelectedItem";
            this.txbSelectedItem.ReadOnly = true;
            this.txbSelectedItem.Size = new System.Drawing.Size(160, 21);
            this.txbSelectedItem.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Món đang chọn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(641, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Số lượng";
            // 
            // dgvTable
            // 
            this.dgvTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.GridColor = System.Drawing.Color.White;
            this.dgvTable.Location = new System.Drawing.Point(12, 26);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(389, 477);
            this.dgvTable.TabIndex = 18;
            // 
            // lsvBillInfo
            // 
            this.lsvBillInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvBillInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBillInfo.GridLines = true;
            this.lsvBillInfo.Location = new System.Drawing.Point(407, 189);
            this.lsvBillInfo.Name = "lsvBillInfo";
            this.lsvBillInfo.Size = new System.Drawing.Size(351, 266);
            this.lsvBillInfo.TabIndex = 21;
            this.lsvBillInfo.UseCompatibleStateImageBehavior = false;
            this.lsvBillInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn";
            this.columnHeader1.Width = 206;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thành tiền";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // btnPay
            // 
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(691, 461);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(67, 42);
            this.btnPay.TabIndex = 22;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.Location = new System.Drawing.Point(577, 469);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(108, 26);
            this.txbTotalPrice.TabIndex = 23;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(573, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Đơn giá";
            // 
            // txbSinglePrice
            // 
            this.txbSinglePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSinglePrice.Location = new System.Drawing.Point(573, 163);
            this.txbSinglePrice.Name = "txbSinglePrice";
            this.txbSinglePrice.ReadOnly = true;
            this.txbSinglePrice.Size = new System.Drawing.Size(69, 21);
            this.txbSinglePrice.TabIndex = 25;
            // 
            // txbFocusTable
            // 
            this.txbFocusTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFocusTable.Location = new System.Drawing.Point(412, 457);
            this.txbFocusTable.Name = "txbFocusTable";
            this.txbFocusTable.ReadOnly = true;
            this.txbFocusTable.Size = new System.Drawing.Size(30, 20);
            this.txbFocusTable.TabIndex = 26;
            this.txbFocusTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbTableList
            // 
            this.cbTableList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTableList.FormattingEnabled = true;
            this.cbTableList.Location = new System.Drawing.Point(473, 456);
            this.cbTableList.Name = "cbTableList";
            this.cbTableList.Size = new System.Drawing.Size(61, 21);
            this.cbTableList.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(448, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "=>";
            // 
            // btnSwapTable
            // 
            this.btnSwapTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwapTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwapTable.Location = new System.Drawing.Point(412, 480);
            this.btnSwapTable.Name = "btnSwapTable";
            this.btnSwapTable.Size = new System.Drawing.Size(75, 23);
            this.btnSwapTable.TabIndex = 29;
            this.btnSwapTable.Text = "Chuyển";
            this.btnSwapTable.UseVisualStyleBackColor = true;
            this.btnSwapTable.Click += new System.EventHandler(this.btnSwapTable_Click);
            // 
            // formTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 507);
            this.Controls.Add(this.btnSwapTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTableList);
            this.Controls.Add(this.txbFocusTable);
            this.Controls.Add(this.txbSinglePrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbTotalPrice);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lsvBillInfo);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSelectedItem);
            this.Controls.Add(this.cbSearchedItem);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmQuantityFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.lbFood);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.cbFood);
            this.Controls.Add(this.cbCategory);
            this.Name = "formTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí";
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantityFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.NumericUpDown nmQuantityFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbSearchedItem;
        private System.Windows.Forms.TextBox txbSelectedItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.ListView lsvBillInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSinglePrice;
        private System.Windows.Forms.TextBox txbFocusTable;
        private System.Windows.Forms.ComboBox cbTableList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSwapTable;
    }
}