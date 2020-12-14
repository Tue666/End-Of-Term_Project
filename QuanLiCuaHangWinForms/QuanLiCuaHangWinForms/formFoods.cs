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
    public partial class formFoods : Form
    {
        public formFoods()
        {
            InitializeComponent();
            loadCombobox();
            loadDataFoods();
        }

        #region Methods
        private void searchFood(string foodName)
        {
            List<Food> listFood = FoodDAL.Singleton.searchFood(foodName);
            dgvFood.DataSource = listFood;
        }
        private void loadCombobox()
        {
            DataTable data = FoodDAL.Singleton.loadComboboxFoodCate();
            foreach(DataRow item in data.Rows)
            {
                CategoryFood foodCate = new CategoryFood(item);
                cbFoodCate.Items.Add(foodCate.CateName);
            }
        }
        private void loadDataFoods()
        {
            dgvFood.DataSource = FoodDAL.Singleton.loadDataFood();
        }
        private void loadColumnFood(int index, CheckBox ck)
        {
            if (ck.Checked == true)
            {
                dgvFood.Columns[index].Visible = true;
            }
            else
            {
                dgvFood.Columns[index].Visible = false;
            }
        }
        private void insertFood(string foodName, string foodCateName, float price, float discount)
        {
            FoodDAL.Singleton.insertFood(foodName, foodCateName, price, discount);
        }
        private void deleteFood(int foodID)
        {
            FoodDAL.Singleton.deleteFood(foodID);
        }
        private void editFood(int foodID, string foodName, string foodCateName, float price, float discount)
        {
            FoodDAL.Singleton.editFood(foodID, foodName, foodCateName, price, discount);
        }
        private void loadImage(int foodID)
        {
            Food food = FoodDAL.Singleton.getInforFood(foodID);
            if (food.UrlImage == "")
            {
                pcImage.Image = new Bitmap(Application.StartupPath + '\\' + "noimage.jpg");
            }
            else
            {
                string[] fileName = food.UrlImage.Split('\\');
                pcImage.Image = new Bitmap(Application.StartupPath + '\\' + fileName[fileName.Length - 1]);
            }
        }
        private bool checkExistFood(int foodID)
        {
            return FoodDAL.Singleton.checkExistFood(foodID);
        }
        #endregion


        #region Events
        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dgvFood.CurrentCell.RowIndex;
            txbFoodID.Text = dgvFood.Rows[currentRow].Cells[0].Value.ToString();
            txbFoodName.Text = dgvFood.Rows[currentRow].Cells[1].Value.ToString();
            cbFoodCate.SelectedItem = dgvFood.Rows[currentRow].Cells[2].Value.ToString();
            txbPrice.Text = dgvFood.Rows[currentRow].Cells[3].Value.ToString();
            txbDiscount.Text = dgvFood.Rows[currentRow].Cells[4].Value.ToString();
            loadImage(Convert.ToInt32(txbFoodID.Text));
        }
        private void ckbID_Click(object sender, EventArgs e)
        {
            loadColumnFood(0, sender as CheckBox);
        }
        private void ckbFoodName_Click(object sender, EventArgs e)
        {
            loadColumnFood(1, sender as CheckBox);
        }
        private void ckbFoodCate_Click(object sender, EventArgs e)
        {
            loadColumnFood(2, sender as CheckBox);
        }
        private void ckbPrice_Click(object sender, EventArgs e)
        {
            loadColumnFood(3, sender as CheckBox);
        }
        private void ckbDiscount_Click(object sender, EventArgs e)
        {
            loadColumnFood(4, sender as CheckBox);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbFoodName.Text != "" || txbPrice.Text!=""|| txbDiscount.Text != "")
            {
                if (!FoodDAL.Singleton.checkExistName(txbFoodName.Text))
                {
                    insertFood(txbFoodName.Text, cbFoodCate.SelectedItem.ToString(), float.Parse(txbPrice.Text), float.Parse(txbDiscount.Text));
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDataFoods();
                }
                else
                {
                    MessageBox.Show("Đã có tên này", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Điền đủ thông tin để thêm", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txbFoodID.Text != "")
            {
                if (checkExistFood(Convert.ToInt32(txbFoodID.Text)))
                {
                    deleteFood(int.Parse(txbFoodID.Text));
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    loadDataFoods();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã thức ăn cần xóa. Xem lại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Điền mã thức ăn cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txbFoodID.Text!=""|| txbFoodName.Text!=""|| txbPrice.Text!=""|| txbDiscount.Text != "")
            {
                editFood(int.Parse(txbFoodID.Text), txbFoodName.Text, cbFoodCate.SelectedItem.ToString(), float.Parse(txbPrice.Text), float.Parse(txbDiscount.Text));
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                loadDataFoods();
            }
            else
            {
                MessageBox.Show("Điền đủ thông tin để sửa", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void btnListFood_Click(object sender, EventArgs e)
        {
            loadDataFoods();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbFoodName.Text != "")
            {
                searchFood(txbFoodName.Text);
            }
            else
            {
                MessageBox.Show("Nhập mã thức ăn cần tìm", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void btnEditImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string[] fileName = openFile.FileName.Split('\\');
                FoodDAL.Singleton.changeImage(Application.StartupPath + '\\' + fileName[fileName.Length - 1], Convert.ToInt32(txbFoodID.Text));
                MessageBox.Show("Cập nhật ảnh thành công", "Thông báo", MessageBoxButtons.OK);
                loadImage(Convert.ToInt32(txbFoodID.Text));
                loadDataFoods();
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            FoodDAL.Singleton.changeImage("", Convert.ToInt32(txbFoodID.Text));
            MessageBox.Show("Xóa ảnh thành công", "Thông báo", MessageBoxButtons.OK);
            loadImage(Convert.ToInt32(txbFoodID.Text));
            loadDataFoods();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["formMainMenu"] as formMainMenu).deleteTab("Thức ăn");
        }
        #endregion
    }
}
