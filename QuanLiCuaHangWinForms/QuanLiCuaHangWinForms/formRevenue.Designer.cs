namespace QuanLiCuaHangWinForms
{
    partial class formRevenue
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.rbBDayCheckOut = new DevComponents.DotNetBar.RibbonBar();
            this.dtICheckOut = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.rbBDayCheckIn = new DevComponents.DotNetBar.RibbonBar();
            this.dtICheckIn = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.rbBDayCheckOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtICheckOut)).BeginInit();
            this.rbBDayCheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtICheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgvSales);
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(800, 450);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnSearch);
            this.groupPanel2.Controls.Add(this.rbBDayCheckOut);
            this.groupPanel2.Controls.Add(this.rbBDayCheckIn);
            this.groupPanel2.Location = new System.Drawing.Point(3, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(788, 111);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(419, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 50);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbBDayCheckOut
            // 
            this.rbBDayCheckOut.AutoOverflowEnabled = true;
            this.rbBDayCheckOut.Controls.Add(this.dtICheckOut);
            this.rbBDayCheckOut.Location = new System.Drawing.Point(206, 3);
            this.rbBDayCheckOut.Name = "rbBDayCheckOut";
            this.rbBDayCheckOut.Size = new System.Drawing.Size(194, 75);
            this.rbBDayCheckOut.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBDayCheckOut.TabIndex = 0;
            this.rbBDayCheckOut.Text = "Ngày ra";
            // 
            // dtICheckOut
            // 
            // 
            // 
            // 
            this.dtICheckOut.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtICheckOut.ButtonDropDown.Visible = true;
            this.dtICheckOut.Location = new System.Drawing.Point(12, 24);
            // 
            // 
            // 
            this.dtICheckOut.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtICheckOut.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtICheckOut.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtICheckOut.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtICheckOut.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtICheckOut.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtICheckOut.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtICheckOut.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtICheckOut.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtICheckOut.MonthCalendar.DisplayMonth = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            this.dtICheckOut.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtICheckOut.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtICheckOut.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtICheckOut.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtICheckOut.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtICheckOut.MonthCalendar.TodayButtonVisible = true;
            this.dtICheckOut.Name = "dtICheckOut";
            this.dtICheckOut.Size = new System.Drawing.Size(170, 20);
            this.dtICheckOut.TabIndex = 1;
            // 
            // rbBDayCheckIn
            // 
            this.rbBDayCheckIn.AutoOverflowEnabled = true;
            this.rbBDayCheckIn.Controls.Add(this.dtICheckIn);
            this.rbBDayCheckIn.Location = new System.Drawing.Point(3, 3);
            this.rbBDayCheckIn.Name = "rbBDayCheckIn";
            this.rbBDayCheckIn.Size = new System.Drawing.Size(197, 75);
            this.rbBDayCheckIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBDayCheckIn.TabIndex = 0;
            this.rbBDayCheckIn.Text = "Ngày vào";
            // 
            // dtICheckIn
            // 
            // 
            // 
            // 
            this.dtICheckIn.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtICheckIn.ButtonDropDown.Visible = true;
            this.dtICheckIn.Location = new System.Drawing.Point(12, 23);
            // 
            // 
            // 
            this.dtICheckIn.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtICheckIn.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtICheckIn.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtICheckIn.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtICheckIn.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtICheckIn.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtICheckIn.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtICheckIn.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtICheckIn.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtICheckIn.MonthCalendar.DisplayMonth = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            this.dtICheckIn.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtICheckIn.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtICheckIn.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtICheckIn.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtICheckIn.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtICheckIn.MonthCalendar.TodayButtonVisible = true;
            this.dtICheckIn.Name = "dtICheckIn";
            this.dtICheckIn.Size = new System.Drawing.Size(170, 20);
            this.dtICheckIn.TabIndex = 0;
            // 
            // dgvSales
            // 
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(3, 120);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(788, 315);
            this.dgvSales.TabIndex = 2;
            // 
            // formRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupPanel1);
            this.Name = "formRevenue";
            this.Text = "formRevenue";
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.rbBDayCheckOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtICheckOut)).EndInit();
            this.rbBDayCheckIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtICheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.RibbonBar rbBDayCheckOut;
        private DevComponents.DotNetBar.RibbonBar rbBDayCheckIn;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtICheckOut;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtICheckIn;
        private System.Windows.Forms.DataGridView dgvSales;
    }
}