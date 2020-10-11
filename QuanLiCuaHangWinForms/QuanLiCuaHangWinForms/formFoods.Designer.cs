namespace QuanLiCuaHangWinForms
{
    partial class formFoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFoods));
            this.ckbPrice = new System.Windows.Forms.CheckBox();
            this.ckbFoodCate = new System.Windows.Forms.CheckBox();
            this.ckbFoodName = new System.Windows.Forms.CheckBox();
            this.ckbID = new System.Windows.Forms.CheckBox();
            this.txbPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbFoodName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbFoodID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbFoodCate = new System.Windows.Forms.Label();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.lbFoodID = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.lbSE2 = new DevComponents.DotNetBar.LabelItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.lbSE1 = new DevComponents.DotNetBar.LabelItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.rbBUpdate = new DevComponents.DotNetBar.RibbonBar();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnExit = new DevComponents.DotNetBar.ButtonItem();
            this.rbBExit = new DevComponents.DotNetBar.RibbonBar();
            this.btnSearch = new DevComponents.DotNetBar.ButtonItem();
            this.rbBSearch = new DevComponents.DotNetBar.RibbonBar();
            this.gpnlAction = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rbBListFood = new DevComponents.DotNetBar.RibbonBar();
            this.btnListFood = new DevComponents.DotNetBar.ButtonItem();
            this.gpnlFood = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbFoodCate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.gpnlAction.SuspendLayout();
            this.gpnlFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbPrice
            // 
            this.ckbPrice.AutoSize = true;
            this.ckbPrice.Checked = true;
            this.ckbPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbPrice.Location = new System.Drawing.Point(320, 149);
            this.ckbPrice.Name = "ckbPrice";
            this.ckbPrice.Size = new System.Drawing.Size(15, 14);
            this.ckbPrice.TabIndex = 6;
            this.ckbPrice.UseVisualStyleBackColor = true;
            this.ckbPrice.Click += new System.EventHandler(this.ckbPrice_Click);
            // 
            // ckbFoodCate
            // 
            this.ckbFoodCate.AutoSize = true;
            this.ckbFoodCate.Checked = true;
            this.ckbFoodCate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbFoodCate.Location = new System.Drawing.Point(320, 112);
            this.ckbFoodCate.Name = "ckbFoodCate";
            this.ckbFoodCate.Size = new System.Drawing.Size(15, 14);
            this.ckbFoodCate.TabIndex = 6;
            this.ckbFoodCate.UseVisualStyleBackColor = true;
            this.ckbFoodCate.Click += new System.EventHandler(this.ckbFoodCate_Click);
            // 
            // ckbFoodName
            // 
            this.ckbFoodName.AutoSize = true;
            this.ckbFoodName.Checked = true;
            this.ckbFoodName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbFoodName.Location = new System.Drawing.Point(320, 75);
            this.ckbFoodName.Name = "ckbFoodName";
            this.ckbFoodName.Size = new System.Drawing.Size(15, 14);
            this.ckbFoodName.TabIndex = 6;
            this.ckbFoodName.UseVisualStyleBackColor = true;
            this.ckbFoodName.Click += new System.EventHandler(this.ckbFoodName_Click);
            // 
            // ckbID
            // 
            this.ckbID.AutoSize = true;
            this.ckbID.Checked = true;
            this.ckbID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbID.Location = new System.Drawing.Point(320, 38);
            this.ckbID.Name = "ckbID";
            this.ckbID.Size = new System.Drawing.Size(15, 14);
            this.ckbID.TabIndex = 6;
            this.ckbID.UseVisualStyleBackColor = true;
            this.ckbID.Click += new System.EventHandler(this.ckbID_Click);
            // 
            // txbPrice
            // 
            // 
            // 
            // 
            this.txbPrice.Border.Class = "TextBoxBorder";
            this.txbPrice.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(109, 145);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(205, 22);
            this.txbPrice.TabIndex = 4;
            // 
            // txbFoodName
            // 
            // 
            // 
            // 
            this.txbFoodName.Border.Class = "TextBoxBorder";
            this.txbFoodName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFoodName.Location = new System.Drawing.Point(109, 71);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(205, 22);
            this.txbFoodName.TabIndex = 2;
            // 
            // txbFoodID
            // 
            // 
            // 
            // 
            this.txbFoodID.Border.Class = "TextBoxBorder";
            this.txbFoodID.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFoodID.Location = new System.Drawing.Point(109, 34);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.Size = new System.Drawing.Size(205, 22);
            this.txbFoodID.TabIndex = 1;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(12, 148);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(26, 15);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Giá";
            // 
            // lbFoodCate
            // 
            this.lbFoodCate.AutoSize = true;
            this.lbFoodCate.BackColor = System.Drawing.Color.Transparent;
            this.lbFoodCate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodCate.Location = new System.Drawing.Point(12, 111);
            this.lbFoodCate.Name = "lbFoodCate";
            this.lbFoodCate.Size = new System.Drawing.Size(31, 15);
            this.lbFoodCate.TabIndex = 4;
            this.lbFoodCate.Text = "Loại";
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.BackColor = System.Drawing.Color.Transparent;
            this.lbFoodName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodName.Location = new System.Drawing.Point(12, 74);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(54, 15);
            this.lbFoodName.TabIndex = 4;
            this.lbFoodName.Text = "Tên món";
            // 
            // lbFoodID
            // 
            this.lbFoodID.AutoSize = true;
            this.lbFoodID.BackColor = System.Drawing.Color.Transparent;
            this.lbFoodID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodID.Location = new System.Drawing.Point(12, 37);
            this.lbFoodID.Name = "lbFoodID";
            this.lbFoodID.Size = new System.Drawing.Size(68, 15);
            this.lbFoodID.TabIndex = 4;
            this.lbFoodID.Text = "Mã thức ăn";
            // 
            // dgvFood
            // 
            this.dgvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(362, 0);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.Size = new System.Drawing.Size(526, 271);
            this.dgvFood.TabIndex = 0;
            this.dgvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellClick);
            // 
            // labelItem3
            // 
            this.labelItem3.BackColor = System.Drawing.Color.White;
            this.labelItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelItem3.Name = "labelItem3";
            // 
            // lbSE2
            // 
            this.lbSE2.BackColor = System.Drawing.Color.White;
            this.lbSE2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSE2.Name = "lbSE2";
            this.lbSE2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem3});
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageFixedSize = new System.Drawing.Size(50, 40);
            this.btnDelete.ImagePaddingHorizontal = 40;
            this.btnDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.SubItemsExpandWidth = 14;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelItem1
            // 
            this.labelItem1.BackColor = System.Drawing.Color.White;
            this.labelItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelItem1.Name = "labelItem1";
            // 
            // lbSE1
            // 
            this.lbSE1.BackColor = System.Drawing.Color.White;
            this.lbSE1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSE1.Name = "lbSE1";
            this.lbSE1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1});
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageFixedSize = new System.Drawing.Size(50, 39);
            this.btnAdd.ImagePaddingHorizontal = 40;
            this.btnAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.SubItemsExpandWidth = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbBUpdate
            // 
            this.rbBUpdate.AutoOverflowEnabled = true;
            this.rbBUpdate.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.lbSE1,
            this.btnDelete,
            this.lbSE2,
            this.btnEdit});
            this.rbBUpdate.Location = new System.Drawing.Point(38, 3);
            this.rbBUpdate.Name = "rbBUpdate";
            this.rbBUpdate.Size = new System.Drawing.Size(289, 78);
            this.rbBUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBUpdate.TabIndex = 0;
            this.rbBUpdate.Text = "Cập nhật";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageFixedSize = new System.Drawing.Size(50, 40);
            this.btnEdit.ImagePaddingHorizontal = 40;
            this.btnEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.SubItemsExpandWidth = 14;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageFixedSize = new System.Drawing.Size(50, 52);
            this.btnExit.ImagePaddingHorizontal = 40;
            this.btnExit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExit.Name = "btnExit";
            this.btnExit.SubItemsExpandWidth = 14;
            // 
            // rbBExit
            // 
            this.rbBExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbBExit.AutoOverflowEnabled = true;
            this.rbBExit.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnExit});
            this.rbBExit.Location = new System.Drawing.Point(743, 3);
            this.rbBExit.Name = "rbBExit";
            this.rbBExit.Size = new System.Drawing.Size(99, 78);
            this.rbBExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBExit.TabIndex = 1;
            this.rbBExit.Text = "Trở về";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnSearch.ImagePaddingHorizontal = 40;
            this.btnSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.SubItemsExpandWidth = 14;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbBSearch
            // 
            this.rbBSearch.AutoOverflowEnabled = true;
            this.rbBSearch.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSearch});
            this.rbBSearch.Location = new System.Drawing.Point(463, 5);
            this.rbBSearch.Name = "rbBSearch";
            this.rbBSearch.Size = new System.Drawing.Size(100, 77);
            this.rbBSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBSearch.TabIndex = 2;
            this.rbBSearch.Text = "Tìm kiếm";
            // 
            // gpnlAction
            // 
            this.gpnlAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpnlAction.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpnlAction.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpnlAction.Controls.Add(this.rbBListFood);
            this.gpnlAction.Controls.Add(this.rbBSearch);
            this.gpnlAction.Controls.Add(this.rbBExit);
            this.gpnlAction.Controls.Add(this.rbBUpdate);
            this.gpnlAction.Location = new System.Drawing.Point(12, 316);
            this.gpnlAction.Name = "gpnlAction";
            this.gpnlAction.Size = new System.Drawing.Size(906, 105);
            // 
            // 
            // 
            this.gpnlAction.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpnlAction.Style.BackColorGradientAngle = 90;
            this.gpnlAction.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpnlAction.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlAction.Style.BorderBottomWidth = 1;
            this.gpnlAction.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpnlAction.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlAction.Style.BorderLeftWidth = 1;
            this.gpnlAction.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlAction.Style.BorderRightWidth = 1;
            this.gpnlAction.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlAction.Style.BorderTopWidth = 1;
            this.gpnlAction.Style.CornerDiameter = 4;
            this.gpnlAction.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpnlAction.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpnlAction.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpnlAction.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.gpnlAction.TabIndex = 5;
            this.gpnlAction.Text = "Tác vụ";
            // 
            // rbBListFood
            // 
            this.rbBListFood.AutoOverflowEnabled = true;
            this.rbBListFood.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnListFood});
            this.rbBListFood.Location = new System.Drawing.Point(333, 4);
            this.rbBListFood.Name = "rbBListFood";
            this.rbBListFood.Size = new System.Drawing.Size(100, 77);
            this.rbBListFood.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBListFood.TabIndex = 3;
            this.rbBListFood.Text = "Danh sách thức ăn";
            // 
            // btnListFood
            // 
            this.btnListFood.Image = ((System.Drawing.Image)(resources.GetObject("btnListFood.Image")));
            this.btnListFood.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnListFood.ImagePaddingHorizontal = 40;
            this.btnListFood.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnListFood.Name = "btnListFood";
            this.btnListFood.SubItemsExpandWidth = 14;
            this.btnListFood.Click += new System.EventHandler(this.btnListFood_Click);
            // 
            // gpnlFood
            // 
            this.gpnlFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpnlFood.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpnlFood.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpnlFood.Controls.Add(this.cbFoodCate);
            this.gpnlFood.Controls.Add(this.label1);
            this.gpnlFood.Controls.Add(this.ckbPrice);
            this.gpnlFood.Controls.Add(this.ckbFoodCate);
            this.gpnlFood.Controls.Add(this.ckbFoodName);
            this.gpnlFood.Controls.Add(this.ckbID);
            this.gpnlFood.Controls.Add(this.txbPrice);
            this.gpnlFood.Controls.Add(this.txbFoodName);
            this.gpnlFood.Controls.Add(this.txbFoodID);
            this.gpnlFood.Controls.Add(this.lbPrice);
            this.gpnlFood.Controls.Add(this.lbFoodCate);
            this.gpnlFood.Controls.Add(this.lbFoodName);
            this.gpnlFood.Controls.Add(this.lbFoodID);
            this.gpnlFood.Controls.Add(this.dgvFood);
            this.gpnlFood.Location = new System.Drawing.Point(12, 7);
            this.gpnlFood.Name = "gpnlFood";
            this.gpnlFood.Size = new System.Drawing.Size(906, 303);
            // 
            // 
            // 
            this.gpnlFood.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpnlFood.Style.BackColorGradientAngle = 90;
            this.gpnlFood.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpnlFood.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlFood.Style.BorderBottomWidth = 1;
            this.gpnlFood.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpnlFood.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlFood.Style.BorderLeftWidth = 1;
            this.gpnlFood.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlFood.Style.BorderRightWidth = 1;
            this.gpnlFood.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlFood.Style.BorderTopWidth = 1;
            this.gpnlFood.Style.CornerDiameter = 4;
            this.gpnlFood.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpnlFood.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpnlFood.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpnlFood.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.gpnlFood.TabIndex = 4;
            this.gpnlFood.Text = "Thông tin thức ăn";
            // 
            // cbFoodCate
            // 
            this.cbFoodCate.FormattingEnabled = true;
            this.cbFoodCate.Location = new System.Drawing.Point(109, 107);
            this.cbFoodCate.Name = "cbFoodCate";
            this.cbFoodCate.Size = new System.Drawing.Size(205, 21);
            this.cbFoodCate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ẩn / Hiện";
            // 
            // formFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 428);
            this.Controls.Add(this.gpnlAction);
            this.Controls.Add(this.gpnlFood);
            this.Name = "formFoods";
            this.Text = "Quản lí thức ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.gpnlAction.ResumeLayout(false);
            this.gpnlFood.ResumeLayout(false);
            this.gpnlFood.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox ckbPrice;
        private System.Windows.Forms.CheckBox ckbFoodCate;
        private System.Windows.Forms.CheckBox ckbFoodName;
        private System.Windows.Forms.CheckBox ckbID;
        private DevComponents.DotNetBar.Controls.TextBoxX txbPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX txbFoodName;
        private DevComponents.DotNetBar.Controls.TextBoxX txbFoodID;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbFoodCate;
        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.Label lbFoodID;
        private System.Windows.Forms.DataGridView dgvFood;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private DevComponents.DotNetBar.LabelItem lbSE2;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem lbSE1;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.RibbonBar rbBUpdate;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnExit;
        private DevComponents.DotNetBar.RibbonBar rbBExit;
        private DevComponents.DotNetBar.ButtonItem btnSearch;
        private DevComponents.DotNetBar.RibbonBar rbBSearch;
        private DevComponents.DotNetBar.Controls.GroupPanel gpnlAction;
        private DevComponents.DotNetBar.Controls.GroupPanel gpnlFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFoodCate;
        private DevComponents.DotNetBar.RibbonBar rbBListFood;
        private DevComponents.DotNetBar.ButtonItem btnListFood;
    }
}