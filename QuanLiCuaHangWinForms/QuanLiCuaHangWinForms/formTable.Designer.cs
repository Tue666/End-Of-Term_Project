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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTable));
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.lsvBillInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.grpAction = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rbBSearchByKey = new DevComponents.DotNetBar.RibbonBar();
            this.btnFind = new DevComponents.DotNetBar.ButtonX();
            this.cbSearchedItem = new System.Windows.Forms.ComboBox();
            this.lbListByKey = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.lbKey = new System.Windows.Forms.Label();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.rbBSerachByCate = new DevComponents.DotNetBar.RibbonBar();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbFood = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.rbBChangeTable = new DevComponents.DotNetBar.RibbonBar();
            this.btnSwapTable = new DevComponents.DotNetBar.ButtonX();
            this.cbTableList = new System.Windows.Forms.ComboBox();
            this.lbToTable = new System.Windows.Forms.Label();
            this.txbFocusTable = new System.Windows.Forms.TextBox();
            this.lbCurrentTable = new System.Windows.Forms.Label();
            this.rbBAddFood = new DevComponents.DotNetBar.RibbonBar();
            this.btnAddFood = new DevComponents.DotNetBar.ButtonX();
            this.nmQuantityFood = new System.Windows.Forms.NumericUpDown();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txbSinglePrice = new System.Windows.Forms.TextBox();
            this.lbSinglePrice = new System.Windows.Forms.Label();
            this.txbSelectedItem = new System.Windows.Forms.TextBox();
            this.lbSelectedItem = new System.Windows.Forms.Label();
            this.comboBoxItem1 = new DevComponents.DotNetBar.ComboBoxItem();
            this.btnPay = new DevComponents.DotNetBar.ButtonX();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbMoveCar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.grpAction.SuspendLayout();
            this.rbBSearchByKey.SuspendLayout();
            this.rbBSerachByCate.SuspendLayout();
            this.rbBChangeTable.SuspendLayout();
            this.rbBAddFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantityFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoveCar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTable.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.GridColor = System.Drawing.Color.White;
            this.dgvTable.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvTable.Location = new System.Drawing.Point(3, 140);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(524, 304);
            this.dgvTable.TabIndex = 18;
            // 
            // lsvBillInfo
            // 
            this.lsvBillInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvBillInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBillInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBillInfo.FullRowSelect = true;
            this.lsvBillInfo.GridLines = true;
            this.lsvBillInfo.Location = new System.Drawing.Point(533, 175);
            this.lsvBillInfo.Name = "lsvBillInfo";
            this.lsvBillInfo.Size = new System.Drawing.Size(384, 269);
            this.lsvBillInfo.TabIndex = 21;
            this.lsvBillInfo.UseCompatibleStateImageBehavior = false;
            this.lsvBillInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn";
            this.columnHeader1.Width = 176;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 61;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Khuyến mãi";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 70;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.Location = new System.Drawing.Point(640, 461);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(108, 26);
            this.txbTotalPrice.TabIndex = 23;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpAction
            // 
            this.grpAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAction.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpAction.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpAction.Controls.Add(this.rbBSearchByKey);
            this.grpAction.Controls.Add(this.rbBSerachByCate);
            this.grpAction.Controls.Add(this.rbBChangeTable);
            this.grpAction.Controls.Add(this.rbBAddFood);
            this.grpAction.Location = new System.Drawing.Point(3, 3);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(914, 131);
            // 
            // 
            // 
            this.grpAction.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpAction.Style.BackColorGradientAngle = 90;
            this.grpAction.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpAction.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpAction.Style.BorderBottomWidth = 1;
            this.grpAction.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpAction.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpAction.Style.BorderLeftWidth = 1;
            this.grpAction.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpAction.Style.BorderRightWidth = 1;
            this.grpAction.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpAction.Style.BorderTopWidth = 1;
            this.grpAction.Style.CornerDiameter = 4;
            this.grpAction.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpAction.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpAction.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpAction.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.grpAction.TabIndex = 30;
            this.grpAction.Text = "Tác vụ";
            // 
            // rbBSearchByKey
            // 
            this.rbBSearchByKey.AutoOverflowEnabled = true;
            this.rbBSearchByKey.Controls.Add(this.btnFind);
            this.rbBSearchByKey.Controls.Add(this.cbSearchedItem);
            this.rbBSearchByKey.Controls.Add(this.lbListByKey);
            this.rbBSearchByKey.Controls.Add(this.txbSearch);
            this.rbBSearchByKey.Controls.Add(this.lbKey);
            this.rbBSearchByKey.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem1});
            this.rbBSearchByKey.Location = new System.Drawing.Point(216, 4);
            this.rbBSearchByKey.Name = "rbBSearchByKey";
            this.rbBSearchByKey.Size = new System.Drawing.Size(224, 101);
            this.rbBSearchByKey.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBSearchByKey.TabIndex = 5;
            this.rbBSearchByKey.Text = "Tìm kiếm theo tên món";
            // 
            // btnFind
            // 
            this.btnFind.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFind.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFind.Location = new System.Drawing.Point(155, 9);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(55, 37);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Tìm";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbSearchedItem
            // 
            this.cbSearchedItem.FormattingEnabled = true;
            this.cbSearchedItem.Location = new System.Drawing.Point(9, 58);
            this.cbSearchedItem.Name = "cbSearchedItem";
            this.cbSearchedItem.Size = new System.Drawing.Size(201, 21);
            this.cbSearchedItem.TabIndex = 3;
            this.cbSearchedItem.SelectedIndexChanged += new System.EventHandler(this.cbSearchedItem_SelectedIndexChanged);
            // 
            // lbListByKey
            // 
            this.lbListByKey.AutoSize = true;
            this.lbListByKey.Location = new System.Drawing.Point(9, 41);
            this.lbListByKey.Name = "lbListByKey";
            this.lbListByKey.Size = new System.Drawing.Size(91, 13);
            this.lbListByKey.TabIndex = 2;
            this.lbListByKey.Text = "Món theo từ khóa";
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(9, 18);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(131, 20);
            this.txbSearch.TabIndex = 1;
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(6, 5);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(47, 13);
            this.lbKey.TabIndex = 0;
            this.lbKey.Text = "Từ khóa";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.lbKey;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // rbBSerachByCate
            // 
            this.rbBSerachByCate.AutoOverflowEnabled = true;
            this.rbBSerachByCate.Controls.Add(this.cbFood);
            this.rbBSerachByCate.Controls.Add(this.cbCategory);
            this.rbBSerachByCate.Controls.Add(this.lbFood);
            this.rbBSerachByCate.Controls.Add(this.lbCategory);
            this.rbBSerachByCate.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.rbBSerachByCate.Location = new System.Drawing.Point(3, 3);
            this.rbBSerachByCate.Name = "rbBSerachByCate";
            this.rbBSerachByCate.Size = new System.Drawing.Size(207, 102);
            this.rbBSerachByCate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBSerachByCate.TabIndex = 4;
            this.rbBSerachByCate.Text = "Tìm kiếm theo danh mục";
            // 
            // cbFood
            // 
            this.cbFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(7, 57);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(188, 21);
            this.cbFood.TabIndex = 1;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(7, 19);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(188, 21);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lbFood
            // 
            this.lbFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFood.AutoSize = true;
            this.lbFood.Location = new System.Drawing.Point(9, 42);
            this.lbFood.Name = "lbFood";
            this.lbFood.Size = new System.Drawing.Size(55, 13);
            this.lbFood.TabIndex = 0;
            this.lbFood.Text = "Sản phẩm";
            // 
            // lbCategory
            // 
            this.lbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(9, 4);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(56, 13);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.Text = "Danh mục";
            // 
            // itemContainer1
            // 
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1});
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            // 
            // rbBChangeTable
            // 
            this.rbBChangeTable.AutoOverflowEnabled = true;
            this.rbBChangeTable.Controls.Add(this.btnSwapTable);
            this.rbBChangeTable.Controls.Add(this.cbTableList);
            this.rbBChangeTable.Controls.Add(this.lbToTable);
            this.rbBChangeTable.Controls.Add(this.txbFocusTable);
            this.rbBChangeTable.Controls.Add(this.lbCurrentTable);
            this.rbBChangeTable.Location = new System.Drawing.Point(775, 3);
            this.rbBChangeTable.Name = "rbBChangeTable";
            this.rbBChangeTable.Size = new System.Drawing.Size(132, 102);
            this.rbBChangeTable.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBChangeTable.TabIndex = 3;
            this.rbBChangeTable.Text = "Chuyển bàn";
            // 
            // btnSwapTable
            // 
            this.btnSwapTable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSwapTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwapTable.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSwapTable.Location = new System.Drawing.Point(70, 18);
            this.btnSwapTable.Name = "btnSwapTable";
            this.btnSwapTable.Size = new System.Drawing.Size(56, 62);
            this.btnSwapTable.TabIndex = 4;
            this.btnSwapTable.Text = "Chuyển";
            this.btnSwapTable.Click += new System.EventHandler(this.btnSwapTable_Click);
            // 
            // cbTableList
            // 
            this.cbTableList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTableList.FormattingEnabled = true;
            this.cbTableList.Location = new System.Drawing.Point(7, 60);
            this.cbTableList.Name = "cbTableList";
            this.cbTableList.Size = new System.Drawing.Size(60, 21);
            this.cbTableList.TabIndex = 3;
            // 
            // lbToTable
            // 
            this.lbToTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbToTable.AutoSize = true;
            this.lbToTable.Location = new System.Drawing.Point(4, 45);
            this.lbToTable.Name = "lbToTable";
            this.lbToTable.Size = new System.Drawing.Size(22, 13);
            this.lbToTable.TabIndex = 2;
            this.lbToTable.Text = "Tới";
            // 
            // txbFocusTable
            // 
            this.txbFocusTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFocusTable.Location = new System.Drawing.Point(6, 23);
            this.txbFocusTable.Name = "txbFocusTable";
            this.txbFocusTable.ReadOnly = true;
            this.txbFocusTable.Size = new System.Drawing.Size(61, 20);
            this.txbFocusTable.TabIndex = 1;
            // 
            // lbCurrentTable
            // 
            this.lbCurrentTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCurrentTable.AutoSize = true;
            this.lbCurrentTable.Location = new System.Drawing.Point(4, 8);
            this.lbCurrentTable.Name = "lbCurrentTable";
            this.lbCurrentTable.Size = new System.Drawing.Size(63, 13);
            this.lbCurrentTable.TabIndex = 0;
            this.lbCurrentTable.Text = "Bàn hiện tại";
            // 
            // rbBAddFood
            // 
            this.rbBAddFood.AutoOverflowEnabled = true;
            this.rbBAddFood.Controls.Add(this.btnAddFood);
            this.rbBAddFood.Controls.Add(this.nmQuantityFood);
            this.rbBAddFood.Controls.Add(this.lbQuantity);
            this.rbBAddFood.Controls.Add(this.txbSinglePrice);
            this.rbBAddFood.Controls.Add(this.lbSinglePrice);
            this.rbBAddFood.Controls.Add(this.txbSelectedItem);
            this.rbBAddFood.Controls.Add(this.lbSelectedItem);
            this.rbBAddFood.Location = new System.Drawing.Point(446, 3);
            this.rbBAddFood.Name = "rbBAddFood";
            this.rbBAddFood.Size = new System.Drawing.Size(323, 101);
            this.rbBAddFood.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBAddFood.TabIndex = 2;
            this.rbBAddFood.Text = "Thêm món";
            // 
            // btnAddFood
            // 
            this.btnAddFood.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddFood.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddFood.Location = new System.Drawing.Point(110, 50);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(117, 30);
            this.btnAddFood.TabIndex = 6;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // nmQuantityFood
            // 
            this.nmQuantityFood.Location = new System.Drawing.Point(271, 27);
            this.nmQuantityFood.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmQuantityFood.Name = "nmQuantityFood";
            this.nmQuantityFood.Size = new System.Drawing.Size(46, 20);
            this.nmQuantityFood.TabIndex = 5;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(269, 10);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(49, 13);
            this.lbQuantity.TabIndex = 4;
            this.lbQuantity.Text = "Số lượng";
            // 
            // txbSinglePrice
            // 
            this.txbSinglePrice.Location = new System.Drawing.Point(188, 28);
            this.txbSinglePrice.Name = "txbSinglePrice";
            this.txbSinglePrice.ReadOnly = true;
            this.txbSinglePrice.Size = new System.Drawing.Size(70, 20);
            this.txbSinglePrice.TabIndex = 3;
            // 
            // lbSinglePrice
            // 
            this.lbSinglePrice.AutoSize = true;
            this.lbSinglePrice.Location = new System.Drawing.Point(186, 10);
            this.lbSinglePrice.Name = "lbSinglePrice";
            this.lbSinglePrice.Size = new System.Drawing.Size(44, 13);
            this.lbSinglePrice.TabIndex = 2;
            this.lbSinglePrice.Text = "Đơn giá";
            // 
            // txbSelectedItem
            // 
            this.txbSelectedItem.Location = new System.Drawing.Point(6, 29);
            this.txbSelectedItem.Name = "txbSelectedItem";
            this.txbSelectedItem.ReadOnly = true;
            this.txbSelectedItem.Size = new System.Drawing.Size(176, 20);
            this.txbSelectedItem.TabIndex = 1;
            // 
            // lbSelectedItem
            // 
            this.lbSelectedItem.AutoSize = true;
            this.lbSelectedItem.Location = new System.Drawing.Point(5, 10);
            this.lbSelectedItem.Name = "lbSelectedItem";
            this.lbSelectedItem.Size = new System.Drawing.Size(83, 13);
            this.lbSelectedItem.TabIndex = 0;
            this.lbSelectedItem.Text = "Món đang chọn";
            // 
            // comboBoxItem1
            // 
            this.comboBoxItem1.Caption = "comboBoxItem1";
            this.comboBoxItem1.ComboWidth = 50;
            this.comboBoxItem1.DropDownHeight = 106;
            this.comboBoxItem1.Name = "comboBoxItem1";
            // 
            // btnPay
            // 
            this.btnPay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(766, 450);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(141, 49);
            this.btnPay.TabIndex = 31;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(701, 140);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 33);
            this.bunifuCustomLabel1.TabIndex = 32;
            this.bunifuCustomLabel1.Text = "Hóa Đơn";
            // 
            // pbMoveCar
            // 
            this.pbMoveCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbMoveCar.Image = ((System.Drawing.Image)(resources.GetObject("pbMoveCar.Image")));
            this.pbMoveCar.Location = new System.Drawing.Point(9, 461);
            this.pbMoveCar.Name = "pbMoveCar";
            this.pbMoveCar.Size = new System.Drawing.Size(88, 38);
            this.pbMoveCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoveCar.TabIndex = 33;
            this.pbMoveCar.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(571, 461);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 23);
            this.labelX1.TabIndex = 34;
            this.labelX1.Text = "Tổng tiền";
            // 
            // formTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 507);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.pbMoveCar);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.txbTotalPrice);
            this.Controls.Add(this.lsvBillInfo);
            this.Controls.Add(this.dgvTable);
            this.Name = "formTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.grpAction.ResumeLayout(false);
            this.rbBSearchByKey.ResumeLayout(false);
            this.rbBSearchByKey.PerformLayout();
            this.rbBSerachByCate.ResumeLayout(false);
            this.rbBSerachByCate.PerformLayout();
            this.rbBChangeTable.ResumeLayout(false);
            this.rbBChangeTable.PerformLayout();
            this.rbBAddFood.ResumeLayout(false);
            this.rbBAddFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantityFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoveCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.ListView lsvBillInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private DevComponents.DotNetBar.Controls.GroupPanel grpAction;
        private DevComponents.DotNetBar.RibbonBar rbBAddFood;
        private DevComponents.DotNetBar.RibbonBar rbBChangeTable;
        private DevComponents.DotNetBar.ComboBoxItem comboBoxItem1;
        private DevComponents.DotNetBar.RibbonBar rbBSerachByCate;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbFood;
        private System.Windows.Forms.Label lbCategory;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private System.Windows.Forms.Label lbKey;
        private DevComponents.DotNetBar.RibbonBar rbBSearchByKey;
        private DevComponents.DotNetBar.ButtonX btnFind;
        private System.Windows.Forms.ComboBox cbSearchedItem;
        private System.Windows.Forms.Label lbListByKey;
        private System.Windows.Forms.TextBox txbSearch;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ButtonX btnAddFood;
        private System.Windows.Forms.NumericUpDown nmQuantityFood;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox txbSinglePrice;
        private System.Windows.Forms.Label lbSinglePrice;
        private System.Windows.Forms.TextBox txbSelectedItem;
        private System.Windows.Forms.Label lbSelectedItem;
        private DevComponents.DotNetBar.ButtonX btnSwapTable;
        private System.Windows.Forms.ComboBox cbTableList;
        private System.Windows.Forms.Label lbToTable;
        private System.Windows.Forms.TextBox txbFocusTable;
        private System.Windows.Forms.Label lbCurrentTable;
        private DevComponents.DotNetBar.ButtonX btnPay;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pbMoveCar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}