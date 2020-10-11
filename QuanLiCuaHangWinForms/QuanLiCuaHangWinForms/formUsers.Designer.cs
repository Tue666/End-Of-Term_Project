namespace QuanLiCuaHangWinForms
{
    partial class formUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsers));
            this.gpnlAction = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rbBSearch = new DevComponents.DotNetBar.RibbonBar();
            this.btnSearch = new DevComponents.DotNetBar.ButtonItem();
            this.rbBExit = new DevComponents.DotNetBar.RibbonBar();
            this.btnExit = new DevComponents.DotNetBar.ButtonItem();
            this.rbBUpdate = new DevComponents.DotNetBar.RibbonBar();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.lbSE1 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.lbSE2 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.gpnlAccount = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbAdress = new System.Windows.Forms.CheckBox();
            this.ckbNumber = new System.Windows.Forms.CheckBox();
            this.ckbSex = new System.Windows.Forms.CheckBox();
            this.ckbEmail = new System.Windows.Forms.CheckBox();
            this.ckbAge = new System.Windows.Forms.CheckBox();
            this.ckbName = new System.Windows.Forms.CheckBox();
            this.ckbType = new System.Windows.Forms.CheckBox();
            this.ckbPass = new System.Windows.Forms.CheckBox();
            this.ckbUserName = new System.Windows.Forms.CheckBox();
            this.ckbID = new System.Windows.Forms.CheckBox();
            this.txbAdress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbSex = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbAge = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.txbUserID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.rbBListUser = new DevComponents.DotNetBar.RibbonBar();
            this.btnListUser = new DevComponents.DotNetBar.ButtonItem();
            this.gpnlAction.SuspendLayout();
            this.gpnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // gpnlAction
            // 
            this.gpnlAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpnlAction.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpnlAction.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpnlAction.Controls.Add(this.rbBListUser);
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
            this.gpnlAction.TabIndex = 3;
            this.gpnlAction.Text = "Tác vụ";
            // 
            // rbBSearch
            // 
            this.rbBSearch.AutoOverflowEnabled = true;
            this.rbBSearch.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSearch});
            this.rbBSearch.Location = new System.Drawing.Point(459, 3);
            this.rbBSearch.Name = "rbBSearch";
            this.rbBSearch.Size = new System.Drawing.Size(100, 77);
            this.rbBSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBSearch.TabIndex = 2;
            this.rbBSearch.Text = "Tìm kiếm";
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
            // rbBExit
            // 
            this.rbBExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbBExit.AutoOverflowEnabled = true;
            this.rbBExit.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnExit});
            this.rbBExit.Location = new System.Drawing.Point(749, 3);
            this.rbBExit.Name = "rbBExit";
            this.rbBExit.Size = new System.Drawing.Size(99, 78);
            this.rbBExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBExit.TabIndex = 1;
            this.rbBExit.Text = "Trở về";
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
            // lbSE1
            // 
            this.lbSE1.BackColor = System.Drawing.Color.White;
            this.lbSE1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSE1.Name = "lbSE1";
            this.lbSE1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1});
            // 
            // labelItem1
            // 
            this.labelItem1.BackColor = System.Drawing.Color.White;
            this.labelItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelItem1.Name = "labelItem1";
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
            // lbSE2
            // 
            this.lbSE2.BackColor = System.Drawing.Color.White;
            this.lbSE2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSE2.Name = "lbSE2";
            this.lbSE2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem3});
            // 
            // labelItem3
            // 
            this.labelItem3.BackColor = System.Drawing.Color.White;
            this.labelItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelItem3.Name = "labelItem3";
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
            // gpnlAccount
            // 
            this.gpnlAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpnlAccount.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpnlAccount.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpnlAccount.Controls.Add(this.label1);
            this.gpnlAccount.Controls.Add(this.ckbAdress);
            this.gpnlAccount.Controls.Add(this.ckbNumber);
            this.gpnlAccount.Controls.Add(this.ckbSex);
            this.gpnlAccount.Controls.Add(this.ckbEmail);
            this.gpnlAccount.Controls.Add(this.ckbAge);
            this.gpnlAccount.Controls.Add(this.ckbName);
            this.gpnlAccount.Controls.Add(this.ckbType);
            this.gpnlAccount.Controls.Add(this.ckbPass);
            this.gpnlAccount.Controls.Add(this.ckbUserName);
            this.gpnlAccount.Controls.Add(this.ckbID);
            this.gpnlAccount.Controls.Add(this.txbAdress);
            this.gpnlAccount.Controls.Add(this.txbNumber);
            this.gpnlAccount.Controls.Add(this.txbSex);
            this.gpnlAccount.Controls.Add(this.txbEmail);
            this.gpnlAccount.Controls.Add(this.txbAge);
            this.gpnlAccount.Controls.Add(this.txbName);
            this.gpnlAccount.Controls.Add(this.txbType);
            this.gpnlAccount.Controls.Add(this.txbPass);
            this.gpnlAccount.Controls.Add(this.txbUserName);
            this.gpnlAccount.Controls.Add(this.lbAdress);
            this.gpnlAccount.Controls.Add(this.lbNumber);
            this.gpnlAccount.Controls.Add(this.lbSex);
            this.gpnlAccount.Controls.Add(this.txbUserID);
            this.gpnlAccount.Controls.Add(this.lbEmail);
            this.gpnlAccount.Controls.Add(this.lbAge);
            this.gpnlAccount.Controls.Add(this.lbName);
            this.gpnlAccount.Controls.Add(this.lbType);
            this.gpnlAccount.Controls.Add(this.lbPass);
            this.gpnlAccount.Controls.Add(this.lbUserName);
            this.gpnlAccount.Controls.Add(this.lbUserID);
            this.gpnlAccount.Controls.Add(this.dgvAccount);
            this.gpnlAccount.Location = new System.Drawing.Point(12, 7);
            this.gpnlAccount.Name = "gpnlAccount";
            this.gpnlAccount.Size = new System.Drawing.Size(906, 303);
            // 
            // 
            // 
            this.gpnlAccount.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpnlAccount.Style.BackColorGradientAngle = 90;
            this.gpnlAccount.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpnlAccount.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlAccount.Style.BorderBottomWidth = 1;
            this.gpnlAccount.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpnlAccount.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlAccount.Style.BorderLeftWidth = 1;
            this.gpnlAccount.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlAccount.Style.BorderRightWidth = 1;
            this.gpnlAccount.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlAccount.Style.BorderTopWidth = 1;
            this.gpnlAccount.Style.CornerDiameter = 4;
            this.gpnlAccount.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpnlAccount.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpnlAccount.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpnlAccount.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.gpnlAccount.TabIndex = 2;
            this.gpnlAccount.Text = "Thông tin tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ẩn / Hiện";
            // 
            // ckbAdress
            // 
            this.ckbAdress.AutoSize = true;
            this.ckbAdress.Checked = true;
            this.ckbAdress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAdress.Location = new System.Drawing.Point(320, 264);
            this.ckbAdress.Name = "ckbAdress";
            this.ckbAdress.Size = new System.Drawing.Size(15, 14);
            this.ckbAdress.TabIndex = 6;
            this.ckbAdress.UseVisualStyleBackColor = true;
            this.ckbAdress.Click += new System.EventHandler(this.ckbAdress_Click);
            // 
            // ckbNumber
            // 
            this.ckbNumber.AutoSize = true;
            this.ckbNumber.Checked = true;
            this.ckbNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbNumber.Location = new System.Drawing.Point(320, 208);
            this.ckbNumber.Name = "ckbNumber";
            this.ckbNumber.Size = new System.Drawing.Size(15, 14);
            this.ckbNumber.TabIndex = 6;
            this.ckbNumber.UseVisualStyleBackColor = true;
            this.ckbNumber.Click += new System.EventHandler(this.ckbNumber_Click);
            // 
            // ckbSex
            // 
            this.ckbSex.AutoSize = true;
            this.ckbSex.Checked = true;
            this.ckbSex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSex.Location = new System.Drawing.Point(320, 153);
            this.ckbSex.Name = "ckbSex";
            this.ckbSex.Size = new System.Drawing.Size(15, 14);
            this.ckbSex.TabIndex = 6;
            this.ckbSex.UseVisualStyleBackColor = true;
            this.ckbSex.Click += new System.EventHandler(this.ckbSex_Click);
            // 
            // ckbEmail
            // 
            this.ckbEmail.AutoSize = true;
            this.ckbEmail.Checked = true;
            this.ckbEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbEmail.Location = new System.Drawing.Point(320, 237);
            this.ckbEmail.Name = "ckbEmail";
            this.ckbEmail.Size = new System.Drawing.Size(15, 14);
            this.ckbEmail.TabIndex = 6;
            this.ckbEmail.UseVisualStyleBackColor = true;
            this.ckbEmail.Click += new System.EventHandler(this.ckbEmail_Click);
            // 
            // ckbAge
            // 
            this.ckbAge.AutoSize = true;
            this.ckbAge.Checked = true;
            this.ckbAge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAge.Location = new System.Drawing.Point(320, 181);
            this.ckbAge.Name = "ckbAge";
            this.ckbAge.Size = new System.Drawing.Size(15, 14);
            this.ckbAge.TabIndex = 6;
            this.ckbAge.UseVisualStyleBackColor = true;
            this.ckbAge.Click += new System.EventHandler(this.ckbAge_Click);
            // 
            // ckbName
            // 
            this.ckbName.AutoSize = true;
            this.ckbName.Checked = true;
            this.ckbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbName.Location = new System.Drawing.Point(320, 126);
            this.ckbName.Name = "ckbName";
            this.ckbName.Size = new System.Drawing.Size(15, 14);
            this.ckbName.TabIndex = 6;
            this.ckbName.UseVisualStyleBackColor = true;
            this.ckbName.Click += new System.EventHandler(this.ckbName_Click);
            // 
            // ckbType
            // 
            this.ckbType.AutoSize = true;
            this.ckbType.Checked = true;
            this.ckbType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbType.Location = new System.Drawing.Point(320, 99);
            this.ckbType.Name = "ckbType";
            this.ckbType.Size = new System.Drawing.Size(15, 14);
            this.ckbType.TabIndex = 6;
            this.ckbType.UseVisualStyleBackColor = true;
            this.ckbType.Click += new System.EventHandler(this.ckbType_Click);
            // 
            // ckbPass
            // 
            this.ckbPass.AutoSize = true;
            this.ckbPass.Checked = true;
            this.ckbPass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbPass.Location = new System.Drawing.Point(320, 71);
            this.ckbPass.Name = "ckbPass";
            this.ckbPass.Size = new System.Drawing.Size(15, 14);
            this.ckbPass.TabIndex = 6;
            this.ckbPass.UseVisualStyleBackColor = true;
            this.ckbPass.Click += new System.EventHandler(this.ckbPass_Click);
            // 
            // ckbUserName
            // 
            this.ckbUserName.AutoSize = true;
            this.ckbUserName.Checked = true;
            this.ckbUserName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUserName.Location = new System.Drawing.Point(320, 44);
            this.ckbUserName.Name = "ckbUserName";
            this.ckbUserName.Size = new System.Drawing.Size(15, 14);
            this.ckbUserName.TabIndex = 6;
            this.ckbUserName.UseVisualStyleBackColor = true;
            this.ckbUserName.Click += new System.EventHandler(this.ckbUserName_Click);
            // 
            // ckbID
            // 
            this.ckbID.AutoSize = true;
            this.ckbID.Checked = true;
            this.ckbID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbID.Location = new System.Drawing.Point(320, 17);
            this.ckbID.Name = "ckbID";
            this.ckbID.Size = new System.Drawing.Size(15, 14);
            this.ckbID.TabIndex = 6;
            this.ckbID.UseVisualStyleBackColor = true;
            this.ckbID.Click += new System.EventHandler(this.ckbID_Click);
            // 
            // txbAdress
            // 
            // 
            // 
            // 
            this.txbAdress.Border.Class = "TextBoxBorder";
            this.txbAdress.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAdress.Location = new System.Drawing.Point(109, 261);
            this.txbAdress.Name = "txbAdress";
            this.txbAdress.Size = new System.Drawing.Size(205, 22);
            this.txbAdress.TabIndex = 10;
            // 
            // txbNumber
            // 
            // 
            // 
            // 
            this.txbNumber.Border.Class = "TextBoxBorder";
            this.txbNumber.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumber.Location = new System.Drawing.Point(109, 205);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(205, 22);
            this.txbNumber.TabIndex = 8;
            // 
            // txbSex
            // 
            // 
            // 
            // 
            this.txbSex.Border.Class = "TextBoxBorder";
            this.txbSex.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSex.Location = new System.Drawing.Point(109, 150);
            this.txbSex.Name = "txbSex";
            this.txbSex.Size = new System.Drawing.Size(205, 22);
            this.txbSex.TabIndex = 6;
            // 
            // txbEmail
            // 
            // 
            // 
            // 
            this.txbEmail.Border.Class = "TextBoxBorder";
            this.txbEmail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(109, 233);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(205, 22);
            this.txbEmail.TabIndex = 9;
            // 
            // txbAge
            // 
            // 
            // 
            // 
            this.txbAge.Border.Class = "TextBoxBorder";
            this.txbAge.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAge.Location = new System.Drawing.Point(109, 177);
            this.txbAge.Name = "txbAge";
            this.txbAge.Size = new System.Drawing.Size(205, 22);
            this.txbAge.TabIndex = 7;
            // 
            // txbName
            // 
            // 
            // 
            // 
            this.txbName.Border.Class = "TextBoxBorder";
            this.txbName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(109, 122);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(205, 22);
            this.txbName.TabIndex = 5;
            // 
            // txbType
            // 
            // 
            // 
            // 
            this.txbType.Border.Class = "TextBoxBorder";
            this.txbType.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbType.Location = new System.Drawing.Point(109, 95);
            this.txbType.Name = "txbType";
            this.txbType.Size = new System.Drawing.Size(205, 22);
            this.txbType.TabIndex = 4;
            // 
            // txbPass
            // 
            // 
            // 
            // 
            this.txbPass.Border.Class = "TextBoxBorder";
            this.txbPass.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPass.Location = new System.Drawing.Point(109, 67);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(205, 22);
            this.txbPass.TabIndex = 3;
            // 
            // txbUserName
            // 
            // 
            // 
            // 
            this.txbUserName.Border.Class = "TextBoxBorder";
            this.txbUserName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(109, 40);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(205, 22);
            this.txbUserName.TabIndex = 2;
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.BackColor = System.Drawing.Color.Transparent;
            this.lbAdress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdress.Location = new System.Drawing.Point(12, 264);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(46, 15);
            this.lbAdress.TabIndex = 4;
            this.lbAdress.Text = "Địa chỉ";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(12, 208);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(77, 15);
            this.lbNumber.TabIndex = 4;
            this.lbNumber.Text = "Số điện thoại";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.BackColor = System.Drawing.Color.Transparent;
            this.lbSex.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Location = new System.Drawing.Point(12, 153);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(56, 15);
            this.lbSex.TabIndex = 4;
            this.lbSex.Text = "Giới tính";
            // 
            // txbUserID
            // 
            // 
            // 
            // 
            this.txbUserID.Border.Class = "TextBoxBorder";
            this.txbUserID.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserID.Location = new System.Drawing.Point(109, 13);
            this.txbUserID.Name = "txbUserID";
            this.txbUserID.Size = new System.Drawing.Size(205, 22);
            this.txbUserID.TabIndex = 1;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(12, 236);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(38, 15);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.BackColor = System.Drawing.Color.Transparent;
            this.lbAge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.Location = new System.Drawing.Point(12, 180);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(31, 15);
            this.lbAge.TabIndex = 4;
            this.lbAge.Text = "Tuổi";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(12, 125);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(28, 15);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Tên";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.BackColor = System.Drawing.Color.Transparent;
            this.lbType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(12, 98);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(31, 15);
            this.lbType.TabIndex = 4;
            this.lbType.Text = "Loại";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(12, 70);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(59, 15);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "Mật khẩu";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(12, 43);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(86, 15);
            this.lbUserName.TabIndex = 4;
            this.lbUserName.Text = "Tên đăng nhập";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.BackColor = System.Drawing.Color.Transparent;
            this.lbUserID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(12, 16);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(91, 15);
            this.lbUserID.TabIndex = 4;
            this.lbUserID.Text = "Mã khách hàng";
            // 
            // dgvAccount
            // 
            this.dgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(372, 3);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(525, 275);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // rbBListUser
            // 
            this.rbBListUser.AutoOverflowEnabled = true;
            this.rbBListUser.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnListUser});
            this.rbBListUser.Location = new System.Drawing.Point(333, 4);
            this.rbBListUser.Name = "rbBListUser";
            this.rbBListUser.Size = new System.Drawing.Size(100, 77);
            this.rbBListUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBListUser.TabIndex = 4;
            this.rbBListUser.Text = "Danh sách khách hàng";
            // 
            // btnListUser
            // 
            this.btnListUser.Image = ((System.Drawing.Image)(resources.GetObject("btnListUser.Image")));
            this.btnListUser.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnListUser.ImagePaddingHorizontal = 40;
            this.btnListUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnListUser.Name = "btnListUser";
            this.btnListUser.SubItemsExpandWidth = 14;
            this.btnListUser.Click += new System.EventHandler(this.btnListUser_Click);
            // 
            // formUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 428);
            this.Controls.Add(this.gpnlAction);
            this.Controls.Add(this.gpnlAccount);
            this.Name = "formUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí người dùng";
            this.gpnlAction.ResumeLayout(false);
            this.gpnlAccount.ResumeLayout(false);
            this.gpnlAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gpnlAction;
        private DevComponents.DotNetBar.RibbonBar rbBExit;
        private DevComponents.DotNetBar.RibbonBar rbBUpdate;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.LabelItem lbSE1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.Controls.GroupPanel gpnlAccount;
        private System.Windows.Forms.DataGridView dgvAccount;
        private DevComponents.DotNetBar.Controls.TextBoxX txbUserID;
        private System.Windows.Forms.Label lbUserID;
        private DevComponents.DotNetBar.Controls.TextBoxX txbSex;
        private DevComponents.DotNetBar.Controls.TextBoxX txbName;
        private DevComponents.DotNetBar.Controls.TextBoxX txbType;
        private DevComponents.DotNetBar.Controls.TextBoxX txbPass;
        private DevComponents.DotNetBar.Controls.TextBoxX txbUserName;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.CheckBox ckbSex;
        private System.Windows.Forms.CheckBox ckbName;
        private System.Windows.Forms.CheckBox ckbType;
        private System.Windows.Forms.CheckBox ckbPass;
        private System.Windows.Forms.CheckBox ckbUserName;
        private System.Windows.Forms.CheckBox ckbID;
        private System.Windows.Forms.CheckBox ckbAdress;
        private System.Windows.Forms.CheckBox ckbNumber;
        private System.Windows.Forms.CheckBox ckbEmail;
        private System.Windows.Forms.CheckBox ckbAge;
        private DevComponents.DotNetBar.Controls.TextBoxX txbAdress;
        private DevComponents.DotNetBar.Controls.TextBoxX txbNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txbEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txbAge;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAge;
        private DevComponents.DotNetBar.LabelItem lbSE2;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.RibbonBar rbBSearch;
        private DevComponents.DotNetBar.ButtonItem btnSearch;
        private DevComponents.DotNetBar.ButtonItem btnExit;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.RibbonBar rbBListUser;
        private DevComponents.DotNetBar.ButtonItem btnListUser;
    }
}