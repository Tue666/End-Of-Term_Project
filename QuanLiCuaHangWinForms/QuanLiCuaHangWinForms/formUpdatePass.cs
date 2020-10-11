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
    public partial class formUpdatePass : Form
    {
        public formUpdatePass()
        {
            InitializeComponent();
            txbUserID.Text = AccountDAL.Id.ToString();
            txbUserName.Text = AccountDAL.UserName;
        }

        #region Methods
        private void changeMode(TextBox txb)
        {
            txb.UseSystemPasswordChar = !txb.UseSystemPasswordChar;
        }
        private void updatePass(int userID, string newPass)
        {
            AccountDAL.Singleton.updatePass(userID, newPass);
        }
        #endregion

        #region Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbOldPass.Text != AccountDAL.PassWord)
            {
                MessageBox.Show("Sai mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txbNewPass1.Text != txbNewPass2.Text)
                {
                    MessageBox.Show("Mật khẩu mới khác nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                    updatePass(AccountDAL.Id, txbNewPass1.Text);
                    this.Close();
                }
            }
        }
        private void pbShow1_Click(object sender, EventArgs e)
        {
            changeMode(txbOldPass);
        }

        private void pbShow2_Click(object sender, EventArgs e)
        {
            changeMode(txbNewPass1);
        }

        private void pbShow3_Click(object sender, EventArgs e)
        {
            changeMode(txbNewPass2);
        }
        #endregion
    }
}
