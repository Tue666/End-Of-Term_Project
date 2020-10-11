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
            //dgvFood.Refresh();
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
        private void insertFood(string foodName, string foodCateName, float price)
        {
            FoodDAL.Singleton.insertFood(foodName, foodCateName, price);
        }
        private void deleteFood(int foodID)
        {
            FoodDAL.Singleton.deleteFood(foodID);
        }
        private void editFood(int foodID, string foodName, string foodCateName, float price)
        {
            FoodDAL.Singleton.editFood(foodID, foodName, foodCateName, price);
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            insertFood(txbFoodName.Text, cbFoodCate.SelectedItem.ToString(), int.Parse(txbPrice.Text));
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            loadDataFoods();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteFood(int.Parse(txbFoodID.Text));
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            loadDataFoods();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editFood(int.Parse(txbFoodID.Text), txbFoodName.Text, cbFoodCate.SelectedItem.ToString(), (float)Convert.ToDouble(txbPrice.Text));
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            loadDataFoods();
        }
        private void btnListFood_Click(object sender, EventArgs e)
        {
            loadDataFoods();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchFood(txbFoodName.Text);
        }
        #endregion
    }
}
