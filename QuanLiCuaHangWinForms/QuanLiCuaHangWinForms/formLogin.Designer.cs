namespace QuanLiCuaHangWinForms
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.txbName = new System.Windows.Forms.TextBox();
            this.lbSEUserName = new System.Windows.Forms.Label();
            this.lbSEPass = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.btnRegis = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pBFacebook = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.Transparent;
            this.txbName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txbName.Location = new System.Drawing.Point(28, 128);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(261, 18);
            this.txbName.TabIndex = 0;
            this.txbName.Text = "Tên đăng nhập ....";
            this.txbName.Click += new System.EventHandler(this.txbName_Click);
            this.txbName.Enter += new System.EventHandler(this.txbName_Enter);
            // 
            // lbSEUserName
            // 
            this.lbSEUserName.BackColor = System.Drawing.Color.White;
            this.lbSEUserName.Location = new System.Drawing.Point(25, 154);
            this.lbSEUserName.Name = "lbSEUserName";
            this.lbSEUserName.Size = new System.Drawing.Size(267, 1);
            this.lbSEUserName.TabIndex = 24;
            this.lbSEUserName.Text = "label1";
            // 
            // lbSEPass
            // 
            this.lbSEPass.BackColor = System.Drawing.Color.White;
            this.lbSEPass.Location = new System.Drawing.Point(25, 206);
            this.lbSEPass.Name = "lbSEPass";
            this.lbSEPass.Size = new System.Drawing.Size(267, 1);
            this.lbSEPass.TabIndex = 26;
            this.lbSEPass.Text = "label2";
            // 
            // txbPass
            // 
            this.txbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPass.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPass.ForeColor = System.Drawing.Color.Transparent;
            this.txbPass.HideSelection = false;
            this.txbPass.Location = new System.Drawing.Point(28, 180);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(261, 18);
            this.txbPass.TabIndex = 1;
            this.txbPass.Text = "Mật khẩu ....";
            this.txbPass.Click += new System.EventHandler(this.txbPass_Click);
            this.txbPass.TextChanged += new System.EventHandler(this.txbPass_TextChanged);
            this.txbPass.Enter += new System.EventHandler(this.txbPass_Enter);
            // 
            // btnRegis
            // 
            this.btnRegis.BackColor = System.Drawing.Color.Transparent;
            this.btnRegis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegis.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegis.ForeColor = System.Drawing.Color.White;
            this.btnRegis.Location = new System.Drawing.Point(28, 324);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(261, 35);
            this.btnRegis.TabIndex = 3;
            this.btnRegis.Text = "Đăng kí";
            this.btnRegis.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLogin.Location = new System.Drawing.Point(28, 283);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(261, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseHover += new System.EventHandler(this.btnLogin_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::QuanLiCuaHangWinForms.Properties.Resources.btnExit;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(283, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 36;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(110, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Đăng nhập bằng";
            // 
            // pBFacebook
            // 
            this.pBFacebook.BackColor = System.Drawing.Color.Transparent;
            this.pBFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBFacebook.Image = ((System.Drawing.Image)(resources.GetObject("pBFacebook.Image")));
            this.pBFacebook.Location = new System.Drawing.Point(48, 406);
            this.pBFacebook.Name = "pBFacebook";
            this.pBFacebook.Size = new System.Drawing.Size(56, 52);
            this.pBFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBFacebook.TabIndex = 37;
            this.pBFacebook.TabStop = false;
            this.pBFacebook.Click += new System.EventHandler(this.pBFacebook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(143, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 33);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nhóm 5";
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(96, 2);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(104, 87);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 34;
            this.ptbLogo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // formLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImage = global::QuanLiCuaHangWinForms.Properties.Resources.backgroundLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(314, 470);
            this.Controls.Add(this.pBFacebook);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.lbSEPass);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.lbSEUserName);
            this.Controls.Add(this.txbName);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formAccount_FormClosing);
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lbSEUserName;
        private System.Windows.Forms.Label lbSEPass;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.Button btnLogin;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pBFacebook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

