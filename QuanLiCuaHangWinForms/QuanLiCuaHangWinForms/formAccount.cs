using QuanLiCuaHangWinForms.DAL;
using QuanLiCuaHangWinForms.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangWinForms
{
    public partial class formAccount : Form
    {
        string filePath = "";
        string urlImage = "";
        public formAccount()
        {
            InitializeComponent();
            getInforUser(AccountDAL.UserName, AccountDAL.PassWord);
            if (urlImage == "")
            {
                pictureBox1.Image = new Bitmap(Application.StartupPath + @"\avatar.png");
            }
            else
            {
                pictureBox1.Image = new Bitmap(urlImage);
            }
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
            if (user.UrlImage != "")
            {
                string[] fileName = user.UrlImage.Split('\\');
                urlImage = Application.StartupPath + @"\" + fileName[fileName.Length - 1];
            }
        }
        private bool changeAvatar(string filePath, int userID)
        {
            return AccountDAL.Singleton.changeAvatar(filePath, userID);
        }
        #endregion

        #region Events
        private void btnUpdateAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] files = openFileDialog.FileName.Split('\\');
                pictureBox1.Image = new Bitmap(Application.StartupPath + @"\" + files[files.Length - 1]);
                filePath = Application.StartupPath + @"\" + files[files.Length - 1];
            }
        }
        private void btnSaveAvatar_Click(object sender, EventArgs e)
        {
            if (filePath != "")
            {
                if (changeAvatar(filePath, AccountDAL.Id))
                {
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
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
