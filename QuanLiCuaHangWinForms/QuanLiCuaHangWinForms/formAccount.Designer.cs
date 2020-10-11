namespace QuanLiCuaHangWinForms
{
    partial class formAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAccount));
            this.gpnlAccount = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.nmAge = new System.Windows.Forms.NumericUpDown();
            this.ckFemale = new System.Windows.Forms.CheckBox();
            this.ckMale = new System.Windows.Forms.CheckBox();
            this.btnSaveAvatar = new System.Windows.Forms.Button();
            this.btnUpdateAvatar = new System.Windows.Forms.Button();
            this.gpnlAvatar = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbUserAdress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbUserEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbUserNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txbUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbUserEmail = new System.Windows.Forms.Label();
            this.lbUserNumber = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.txbUserID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbUserID = new System.Windows.Forms.Label();
            this.gpnlAction = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.rbBExit = new DevComponents.DotNetBar.RibbonBar();
            this.btnExit = new DevComponents.DotNetBar.ButtonItem();
            this.rbBUpdate = new DevComponents.DotNetBar.RibbonBar();
            this.btnUpdateInfor = new DevComponents.DotNetBar.ButtonItem();
            this.lbSE1 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.btnUpdatePass = new DevComponents.DotNetBar.ButtonItem();
            this.gpnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAge)).BeginInit();
            this.gpnlAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpnlAccount
            // 
            this.gpnlAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpnlAccount.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpnlAccount.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpnlAccount.Controls.Add(this.nmAge);
            this.gpnlAccount.Controls.Add(this.ckFemale);
            this.gpnlAccount.Controls.Add(this.ckMale);
            this.gpnlAccount.Controls.Add(this.btnSaveAvatar);
            this.gpnlAccount.Controls.Add(this.btnUpdateAvatar);
            this.gpnlAccount.Controls.Add(this.gpnlAvatar);
            this.gpnlAccount.Controls.Add(this.txbUserAdress);
            this.gpnlAccount.Controls.Add(this.txbUserEmail);
            this.gpnlAccount.Controls.Add(this.txbUserNumber);
            this.gpnlAccount.Controls.Add(this.txbUserName);
            this.gpnlAccount.Controls.Add(this.lbAdress);
            this.gpnlAccount.Controls.Add(this.lbUserEmail);
            this.gpnlAccount.Controls.Add(this.lbUserNumber);
            this.gpnlAccount.Controls.Add(this.lbAge);
            this.gpnlAccount.Controls.Add(this.lbUserName);
            this.gpnlAccount.Controls.Add(this.txbUserID);
            this.gpnlAccount.Controls.Add(this.lbUserID);
            this.gpnlAccount.Location = new System.Drawing.Point(12, 2);
            this.gpnlAccount.Name = "gpnlAccount";
            this.gpnlAccount.Size = new System.Drawing.Size(906, 262);
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
            this.gpnlAccount.TabIndex = 0;
            this.gpnlAccount.Text = "Thông tin tài khoản";
            // 
            // nmAge
            // 
            this.nmAge.Enabled = false;
            this.nmAge.Location = new System.Drawing.Point(129, 92);
            this.nmAge.Name = "nmAge";
            this.nmAge.ReadOnly = true;
            this.nmAge.Size = new System.Drawing.Size(51, 20);
            this.nmAge.TabIndex = 7;
            // 
            // ckFemale
            // 
            this.ckFemale.AutoSize = true;
            this.ckFemale.BackColor = System.Drawing.Color.Transparent;
            this.ckFemale.Enabled = false;
            this.ckFemale.Location = new System.Drawing.Point(288, 93);
            this.ckFemale.Name = "ckFemale";
            this.ckFemale.Size = new System.Drawing.Size(40, 17);
            this.ckFemale.TabIndex = 6;
            this.ckFemale.Text = "Nữ";
            this.ckFemale.UseVisualStyleBackColor = false;
            // 
            // ckMale
            // 
            this.ckMale.AutoSize = true;
            this.ckMale.BackColor = System.Drawing.Color.Transparent;
            this.ckMale.Checked = true;
            this.ckMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckMale.Enabled = false;
            this.ckMale.Location = new System.Drawing.Point(221, 93);
            this.ckMale.Name = "ckMale";
            this.ckMale.Size = new System.Drawing.Size(48, 17);
            this.ckMale.TabIndex = 6;
            this.ckMale.Text = "Nam";
            this.ckMale.UseVisualStyleBackColor = false;
            // 
            // btnSaveAvatar
            // 
            this.btnSaveAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAvatar.Location = new System.Drawing.Point(716, 197);
            this.btnSaveAvatar.Name = "btnSaveAvatar";
            this.btnSaveAvatar.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAvatar.TabIndex = 4;
            this.btnSaveAvatar.Text = "Lưu";
            this.btnSaveAvatar.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAvatar
            // 
            this.btnUpdateAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateAvatar.Location = new System.Drawing.Point(635, 197);
            this.btnUpdateAvatar.Name = "btnUpdateAvatar";
            this.btnUpdateAvatar.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAvatar.TabIndex = 3;
            this.btnUpdateAvatar.Text = "Thay đổi";
            this.btnUpdateAvatar.UseVisualStyleBackColor = true;
            // 
            // gpnlAvatar
            // 
            this.gpnlAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpnlAvatar.BackColor = System.Drawing.Color.Transparent;
            this.gpnlAvatar.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpnlAvatar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpnlAvatar.Controls.Add(this.pictureBox1);
            this.gpnlAvatar.Location = new System.Drawing.Point(530, 3);
            this.gpnlAvatar.Name = "gpnlAvatar";
            this.gpnlAvatar.Size = new System.Drawing.Size(357, 188);
            // 
            // 
            // 
            this.gpnlAvatar.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpnlAvatar.Style.BackColorGradientAngle = 90;
            this.gpnlAvatar.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpnlAvatar.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlAvatar.Style.BorderBottomWidth = 1;
            this.gpnlAvatar.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpnlAvatar.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlAvatar.Style.BorderLeftWidth = 1;
            this.gpnlAvatar.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlAvatar.Style.BorderRightWidth = 1;
            this.gpnlAvatar.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpnlAvatar.Style.BorderTopWidth = 1;
            this.gpnlAvatar.Style.CornerDiameter = 4;
            this.gpnlAvatar.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpnlAvatar.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpnlAvatar.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpnlAvatar.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.gpnlAvatar.TabIndex = 2;
            this.gpnlAvatar.Text = "Ảnh đại diện";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txbUserAdress
            // 
            // 
            // 
            // 
            this.txbUserAdress.Border.Class = "TextBoxBorder";
            this.txbUserAdress.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserAdress.Location = new System.Drawing.Point(129, 204);
            this.txbUserAdress.Name = "txbUserAdress";
            this.txbUserAdress.ReadOnly = true;
            this.txbUserAdress.Size = new System.Drawing.Size(379, 22);
            this.txbUserAdress.TabIndex = 1;
            // 
            // txbUserEmail
            // 
            // 
            // 
            // 
            this.txbUserEmail.Border.Class = "TextBoxBorder";
            this.txbUserEmail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserEmail.Location = new System.Drawing.Point(129, 162);
            this.txbUserEmail.Name = "txbUserEmail";
            this.txbUserEmail.ReadOnly = true;
            this.txbUserEmail.Size = new System.Drawing.Size(379, 22);
            this.txbUserEmail.TabIndex = 1;
            // 
            // txbUserNumber
            // 
            // 
            // 
            // 
            this.txbUserNumber.Border.Class = "TextBoxBorder";
            this.txbUserNumber.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserNumber.Location = new System.Drawing.Point(129, 123);
            this.txbUserNumber.Name = "txbUserNumber";
            this.txbUserNumber.ReadOnly = true;
            this.txbUserNumber.Size = new System.Drawing.Size(379, 22);
            this.txbUserNumber.TabIndex = 1;
            // 
            // txbUserName
            // 
            // 
            // 
            // 
            this.txbUserName.Border.Class = "TextBoxBorder";
            this.txbUserName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(129, 61);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(379, 22);
            this.txbUserName.TabIndex = 1;
            // 
            // lbAdress
            // 
            this.lbAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAdress.AutoSize = true;
            this.lbAdress.BackColor = System.Drawing.Color.Transparent;
            this.lbAdress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdress.Location = new System.Drawing.Point(23, 209);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(46, 15);
            this.lbAdress.TabIndex = 0;
            this.lbAdress.Text = "Địa chỉ";
            // 
            // lbUserEmail
            // 
            this.lbUserEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserEmail.AutoSize = true;
            this.lbUserEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbUserEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserEmail.Location = new System.Drawing.Point(23, 167);
            this.lbUserEmail.Name = "lbUserEmail";
            this.lbUserEmail.Size = new System.Drawing.Size(38, 15);
            this.lbUserEmail.TabIndex = 0;
            this.lbUserEmail.Text = "Email";
            // 
            // lbUserNumber
            // 
            this.lbUserNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserNumber.AutoSize = true;
            this.lbUserNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbUserNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserNumber.Location = new System.Drawing.Point(23, 128);
            this.lbUserNumber.Name = "lbUserNumber";
            this.lbUserNumber.Size = new System.Drawing.Size(77, 15);
            this.lbUserNumber.TabIndex = 0;
            this.lbUserNumber.Text = "Số điện thoại";
            // 
            // lbAge
            // 
            this.lbAge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAge.AutoSize = true;
            this.lbAge.BackColor = System.Drawing.Color.Transparent;
            this.lbAge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.Location = new System.Drawing.Point(24, 96);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(31, 15);
            this.lbAge.TabIndex = 0;
            this.lbAge.Text = "Tuổi";
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(23, 66);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(95, 15);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Tên khách hàng";
            // 
            // txbUserID
            // 
            // 
            // 
            // 
            this.txbUserID.Border.Class = "TextBoxBorder";
            this.txbUserID.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserID.Location = new System.Drawing.Point(129, 22);
            this.txbUserID.Name = "txbUserID";
            this.txbUserID.ReadOnly = true;
            this.txbUserID.Size = new System.Drawing.Size(379, 22);
            this.txbUserID.TabIndex = 1;
            // 
            // lbUserID
            // 
            this.lbUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserID.AutoSize = true;
            this.lbUserID.BackColor = System.Drawing.Color.Transparent;
            this.lbUserID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(23, 27);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(91, 15);
            this.lbUserID.TabIndex = 0;
            this.lbUserID.Text = "Mã khách hàng";
            // 
            // gpnlAction
            // 
            this.gpnlAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpnlAction.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpnlAction.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpnlAction.Controls.Add(this.rbBExit);
            this.gpnlAction.Controls.Add(this.rbBUpdate);
            this.gpnlAction.Location = new System.Drawing.Point(12, 270);
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
            this.gpnlAction.TabIndex = 1;
            this.gpnlAction.Text = "Tác vụ";
            // 
            // rbBExit
            // 
            this.rbBExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbBExit.AutoOverflowEnabled = true;
            this.rbBExit.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnExit});
            this.rbBExit.Location = new System.Drawing.Point(755, 3);
            this.rbBExit.Name = "rbBExit";
            this.rbBExit.Size = new System.Drawing.Size(96, 78);
            this.rbBExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBExit.TabIndex = 1;
            this.rbBExit.Text = "Trở về";
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageFixedSize = new System.Drawing.Size(50, 52);
            this.btnExit.ImagePaddingHorizontal = 35;
            this.btnExit.Name = "btnExit";
            this.btnExit.SubItemsExpandWidth = 14;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rbBUpdate
            // 
            this.rbBUpdate.AutoOverflowEnabled = true;
            this.rbBUpdate.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnUpdateInfor,
            this.lbSE1,
            this.btnUpdatePass});
            this.rbBUpdate.Location = new System.Drawing.Point(38, 3);
            this.rbBUpdate.Name = "rbBUpdate";
            this.rbBUpdate.Size = new System.Drawing.Size(194, 78);
            this.rbBUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBUpdate.TabIndex = 0;
            this.rbBUpdate.Text = "Cập nhật";
            // 
            // btnUpdateInfor
            // 
            this.btnUpdateInfor.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateInfor.Image")));
            this.btnUpdateInfor.ImageFixedSize = new System.Drawing.Size(50, 39);
            this.btnUpdateInfor.ImagePaddingHorizontal = 40;
            this.btnUpdateInfor.ImagePaddingVertical = 1;
            this.btnUpdateInfor.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUpdateInfor.Name = "btnUpdateInfor";
            this.btnUpdateInfor.SubItemsExpandWidth = 14;
            this.btnUpdateInfor.Text = "Thông tin";
            this.btnUpdateInfor.Click += new System.EventHandler(this.btnUpdateInfor_Click);
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
            // btnUpdatePass
            // 
            this.btnUpdatePass.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdatePass.Image")));
            this.btnUpdatePass.ImageFixedSize = new System.Drawing.Size(50, 40);
            this.btnUpdatePass.ImagePaddingHorizontal = 40;
            this.btnUpdatePass.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.SubItemsExpandWidth = 14;
            this.btnUpdatePass.Text = "Mật khẩu";
            this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click);
            // 
            // formAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 387);
            this.Controls.Add(this.gpnlAction);
            this.Controls.Add(this.gpnlAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin";
            this.gpnlAccount.ResumeLayout(false);
            this.gpnlAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAge)).EndInit();
            this.gpnlAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpnlAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gpnlAccount;
        private DevComponents.DotNetBar.Controls.GroupPanel gpnlAction;
        private System.Windows.Forms.Button btnSaveAvatar;
        private System.Windows.Forms.Button btnUpdateAvatar;
        private DevComponents.DotNetBar.Controls.GroupPanel gpnlAvatar;
        private DevComponents.DotNetBar.Controls.TextBoxX txbUserID;
        private System.Windows.Forms.Label lbUserID;
        private DevComponents.DotNetBar.Controls.TextBoxX txbUserName;
        private System.Windows.Forms.Label lbUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX txbUserNumber;
        private System.Windows.Forms.Label lbUserNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txbUserAdress;
        private DevComponents.DotNetBar.Controls.TextBoxX txbUserEmail;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbUserEmail;
        private DevComponents.DotNetBar.RibbonBar rbBUpdate;
        private DevComponents.DotNetBar.ButtonItem btnUpdateInfor;
        private DevComponents.DotNetBar.LabelItem lbSE1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.RibbonBar rbBExit;
        private DevComponents.DotNetBar.ButtonItem btnExit;
        private DevComponents.DotNetBar.ButtonItem btnUpdatePass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ckFemale;
        private System.Windows.Forms.CheckBox ckMale;
        private System.Windows.Forms.NumericUpDown nmAge;
        private System.Windows.Forms.Label lbAge;
    }
}