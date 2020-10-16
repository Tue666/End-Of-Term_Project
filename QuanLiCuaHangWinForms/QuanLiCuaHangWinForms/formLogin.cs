using DevComponents.DotNetBar;
using QuanLiCuaHangWinForms.DAL;
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
    public partial class formLogin : Form
    {
        formLoginFacebook fLoginFacebook = new formLoginFacebook();
        public formLogin()
        {
            InitializeComponent();
        }

        #region Methods
        bool Login(string userName, string passWord)
        {
            return AccountDAL.Singleton.Login(userName, passWord);
        }
        #endregion

        #region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbName.Text;
            string passWord = txbPass.Text;
            if (Login(userName, passWord))
            {
                formMainMenu fMainMenu = new formMainMenu();
                this.Hide();
                fMainMenu.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên hoặc mật khẩu");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            formUsers fAdmin = new formUsers();
            fAdmin.Show();
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
        private void pBFacebook_Click(object sender, EventArgs e)
        {
            //fLoginFacebook = new formLoginFacebook();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            fLoginFacebook.Left += 10;
            if (fLoginFacebook.Left >= 835)
            {
                timer1.Stop();
                fLoginFacebook.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fLoginFacebook.Left -= 10;
            if (fLoginFacebook.Left <= 527)
            {
                timer2.Stop();
            }
        }
        private void formLogin_Load(object sender, EventArgs e)
        {
            fLoginFacebook.Show();
        }

        #endregion
    }
}
