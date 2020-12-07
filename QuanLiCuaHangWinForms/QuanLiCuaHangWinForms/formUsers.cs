using QuanLiCuaHangWinForms.DAL;
using QuanLiCuaHangWinForms.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangWinForms
{
    public partial class formUsers : Form
    {
        public formUsers()
        {
            InitializeComponent();
            loadDataAccount();
        }

        #region Methods
        private void searchUser(string userName)
        {
            List<User> listUser = AccountDAL.Singleton.searchUser(userName);
            dgvAccount.DataSource = listUser;
        }
        private void loadDataAccount()
        {
            //dgvAccount.Refresh();
            dgvAccount.DataSource = AccountDAL.Singleton.loadDataAccount();
        }
        private void insertUser(string userName, string passWord, int Type, string name = "", string sex = "", int age = 0, string number = "", string email = "", string adress = "")
        {
            AccountDAL.Singleton.insertUser(userName, passWord, Type, name, sex, age, number, email, adress);
        }
        private void deleteUser(int userID)
        {
            AccountDAL.Singleton.deleteUser(userID);
        }
        private void editUser(int userID, string userName, string passWord, int Type, string name = "", string sex = "", int age = 0, string number = "", string email = "", string adress = "")
        {
            AccountDAL.Singleton.editUser(userID, userName, passWord, Type, name, sex, age, number, email, adress);
        }
        private void loadColumnUser(int index, CheckBox ck)
        {
            if (ck.Checked == true)
            {
                dgvAccount.Columns[index].Visible = true;
            }
            else
            {
                dgvAccount.Columns[index].Visible = false;
            }
        }
        private void loadImage(string userName, string passWord)
        {
            User user = AccountDAL.Singleton.getInforUser(userName, passWord);
            if (user.UrlImage == "")
            {
                pcImage.Image = new Bitmap(Application.StartupPath + '\\' + "noimage.jpg");
            }
            else
            {
                string[] fileName = user.UrlImage.Split('\\');
                pcImage.Image = new Bitmap(Application.StartupPath + '\\' + fileName[fileName.Length - 1]);
            }
        }
        #endregion

        #region Events
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dgvAccount.CurrentCell.RowIndex;
            txbUserID.Text = dgvAccount.Rows[currentRow].Cells[0].Value.ToString();
            txbUserName.Text = dgvAccount.Rows[currentRow].Cells[1].Value.ToString();
            txbPass.Text = dgvAccount.Rows[currentRow].Cells[2].Value.ToString();
            txbType.Text = dgvAccount.Rows[currentRow].Cells[3].Value.ToString();
            txbName.Text = dgvAccount.Rows[currentRow].Cells[4].Value.ToString();
            txbSex.Text = dgvAccount.Rows[currentRow].Cells[5].Value.ToString();
            txbAge.Text = dgvAccount.Rows[currentRow].Cells[6].Value.ToString();
            txbNumber.Text = dgvAccount.Rows[currentRow].Cells[7].Value.ToString();
            txbEmail.Text = dgvAccount.Rows[currentRow].Cells[8].Value.ToString();
            txbAdress.Text = dgvAccount.Rows[currentRow].Cells[9].Value.ToString();
            loadImage(txbUserName.Text, txbPass.Text);
        }
        private void ckbID_Click(object sender, EventArgs e)
        {
            loadColumnUser(0, sender as CheckBox);
        }

        private void ckbUserName_Click(object sender, EventArgs e)
        {
            loadColumnUser(1, sender as CheckBox);
        }

        private void ckbPass_Click(object sender, EventArgs e)
        {
            loadColumnUser(2, sender as CheckBox);
        }

        private void ckbType_Click(object sender, EventArgs e)
        {
            loadColumnUser(3, sender as CheckBox);
        }

        private void ckbName_Click(object sender, EventArgs e)
        {
            loadColumnUser(4, sender as CheckBox);
        }

        private void ckbSex_Click(object sender, EventArgs e)
        {
            loadColumnUser(5, sender as CheckBox);
        }

        private void ckbAge_Click(object sender, EventArgs e)
        {
            loadColumnUser(6, sender as CheckBox);
        }

        private void ckbNumber_Click(object sender, EventArgs e)
        {
            loadColumnUser(7, sender as CheckBox);
        }

        private void ckbEmail_Click(object sender, EventArgs e)
        {
            loadColumnUser(8, sender as CheckBox);
        }

        private void ckbAdress_Click(object sender, EventArgs e)
        {
            loadColumnUser(9, sender as CheckBox);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text != "" || txbPass.Text != "" || txbType.Text != "")
            {
                insertUser(txbUserName.Text, txbPass.Text, int.Parse(txbType.Text), txbName.Text, txbSex.Text, int.Parse(txbAge.Text), txbNumber.Text, txbEmail.Text, txbAdress.Text);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                loadDataAccount();
            }
            else
            {
                MessageBox.Show("Điền đủ thông tin để thêm", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txbUserID.Text != "")
            {
                deleteUser(int.Parse(txbUserID.Text));
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                loadDataAccount();
            }
            else
            {
                MessageBox.Show("Điền mã khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txbUserID.Text != ""|| txbUserName.Text != "" || txbPass.Text != "" || txbType.Text != "")
            {
                editUser(int.Parse(txbUserID.Text), txbUserName.Text, txbPass.Text, int.Parse(txbType.Text), txbName.Text, txbSex.Text, int.Parse(txbAge.Text), txbNumber.Text, txbEmail.Text, txbAdress.Text);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                loadDataAccount();
            }
            else
            {
                MessageBox.Show("Điền đủ thông tin để sửa", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void btnListUser_Click(object sender, EventArgs e)
        {
            loadDataAccount();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text != "")
            {
                searchUser(txbUserName.Text);
            }
            else
            {
                MessageBox.Show("Nhập tên khách hàng cần tìm", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void btnEditImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string[] fileName = openFile.FileName.Split('\\');
                AccountDAL.Singleton.changeAvatar(Application.StartupPath + '\\' + fileName[fileName.Length - 1],Convert.ToInt32(txbUserID.Text));
                MessageBox.Show("Cập nhật ảnh thành công", "Thông báo", MessageBoxButtons.OK);
                loadImage(txbUserName.Text, txbPass.Text);
                loadDataAccount();
            }
        }
        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            AccountDAL.Singleton.changeAvatar("", Convert.ToInt32(txbUserID.Text));
            MessageBox.Show("Xóa ảnh thành công", "Thông báo", MessageBoxButtons.OK);
            loadImage(txbUserName.Text, txbPass.Text);
            loadDataAccount();
        }
        #endregion
    }
}
