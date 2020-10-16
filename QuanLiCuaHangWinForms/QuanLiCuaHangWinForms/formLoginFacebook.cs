using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangWinForms
{
    public partial class formLoginFacebook : Form
    {
        public formLoginFacebook()
        {
            InitializeComponent();
        }

        #region Methods
        #endregion

        #region Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txbName_Click(object sender, EventArgs e)
        {
            txbName.Clear();
        }
        private void txbPass_Click(object sender, EventArgs e)
        {
            txbPass.Clear();
        }
        private void txbPass_TextChanged(object sender, EventArgs e)
        {
            txbPass.UseSystemPasswordChar = true;
        }
        private void txbName_Enter(object sender, EventArgs e)
        {
            lbSEUserName.BackColor = SystemColors.HotTrack;
            lbSEPass.BackColor = Color.White;
        }

        private void txbPass_Enter(object sender, EventArgs e)
        {
            lbSEPass.BackColor = SystemColors.HotTrack;
            lbSEUserName.BackColor = Color.White;
        }
        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = SystemColors.Highlight;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này đang bảo trì!. Quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left += 10;
            if (this.Left >= 835)
            {
                timer1.Stop();
                this.TopMost = false;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Left -= 10;
            if (this.Left <= 527)
            {
                timer2.Stop();
                this.TopMost = false;
            }
        }
        #endregion
    }
}
