using QuanLiCuaHangWinForms.DAL;
using QuanLiCuaHangWinForms.DTO;
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
    public partial class formAccount : Form
    {
        public formAccount()
        {
            InitializeComponent();
            getInforUser(AccountDAL.UserName, AccountDAL.PassWord);
        }
        #region Methods
        private void getInforUser(string userName, string passWord)
        {
            User user = AccountDAL.Singleton.getInforUser(userName, passWord);
            txbUserID.Text = user.Id.ToString();
            txbUserName.Text = user.Name;
            nmAge.Value = user.Age;
            if (user.Sex == "Nữ")
            {
                ckFemale.Checked = true;
                ckMale.Checked = false;
            }
            else
            {
                ckMale.Checked = true;
                ckFemale.Checked = false;
            }
            txbUserNumber.Text = user.Number;
            txbUserEmail.Text = user.Email;
            txbUserAdress.Text = user.Adress;
        }
        #endregion

        #region Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdateInfor_Click(object sender, EventArgs e)
        {
            formUpdateInfor fUpdateInfor = new formUpdateInfor();
            fUpdateInfor.ShowDialog();
            getInforUser(AccountDAL.UserName, AccountDAL.PassWord);
        }
        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            formUpdatePass fUpdatePass = new formUpdatePass();
            fUpdatePass.ShowDialog();
        }
        #endregion
    }
}
