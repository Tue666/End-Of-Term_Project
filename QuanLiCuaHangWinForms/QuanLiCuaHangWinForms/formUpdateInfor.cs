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
    public partial class formUpdateInfor : Form
    {
        public formUpdateInfor()
        {
            InitializeComponent();
            loadInfo();
        }

        #region Methods
        private void loadInfo()
        {
            User user = AccountDAL.Singleton.getInforUser(AccountDAL.UserName,AccountDAL.PassWord);
            txbUserID.Text = user.Id.ToString();
            txbUserName.Text = user.UserName;

            txbName.Text = user.Name;
            txbSex.Text = user.Sex;
            txbAge.Text = user.Age.ToString();
            txbNumber.Text = user.Number;
            txbEmail.Text = user.Email;
            txbAdress.Text = user.Adress;
        }
        private void updateInfor(int userID, string userName, string passWord, int Type, string name,string sex, int age, string number, string email, string adress)
        {
            AccountDAL.Singleton.editUser(userID, userName, passWord, Type, name, sex, age, number, email, adress);
        }
        #endregion

        #region Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            updateInfor(int.Parse(txbUserID.Text), txbUserName.Text,AccountDAL.PassWord,AccountDAL.Type, txbName.Text, txbSex.Text, int.Parse(txbAge.Text), txbNumber.Text, txbEmail.Text, txbAdress.Text);
            MessageBox.Show("Cập nhật thành công");
            this.Close();
        }
        #endregion
    }
}
