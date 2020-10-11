using QuanLiCuaHangWinForms.DAL;
using QuanLiCuaHangWinForms.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangWinForms
{
    public partial class formTable : Form
    {
        public formTable()
        {
            InitializeComponent();
            
            loadTableList();
            loadCategoryFood();
            loadComboboxTable(cbTableList);
        }
        #region Methods
        void loadCategoryFood()
        {
            List<CategoryFood> listCateFood = CategoryFoodDAL.Singleton.listCateFood();
            cbCategory.DataSource = listCateFood;
            cbCategory.DisplayMember = "cateName";
        }
        void loadFoodByCategoryID(int cateID)
        {
            List<Food> listFood = FoodDAL.Singleton.listFoodByCateID(cateID);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "foodName";
        }
        Button[] buttonList = new Button[10];
        void loadTableList()
        {
            int i = 1, x, y;
            List<Table> tableList = TableDAL.Singleton.tableList();
            
            foreach (Table item in tableList)
            {
                if (i == 1 || i == 3 || i == 5) x = 42;
                else x = 241;
                if (i == 1 || i == 2) y = 70;
                else if (i == 3 || i == 4) y = 225;
                else y = 372;
                buttonList[i] = new Button() { Width = TableDAL.TableW, Height = TableDAL.TableH };
                buttonList[i].Text = item.Name + Environment.NewLine + item.Status;
                buttonList[i].Location = new Point(x, y);
                if (item.Status == "Trống")
                    buttonList[i].BackColor = Color.Aqua;
                else
                    buttonList[i].BackColor = Color.Pink;
                dgvTable.Controls.Add(buttonList[i]);
                buttonList[i].Click += Btn_Click;
                buttonList[i].Tag = item;
                i++;
            }
        }
        void showBill(int tableID)
        {
            double totalPrice = 0;
            lsvBillInfo.Items.Clear();
            List<BillInfo>  listBillInfo = BillInfoDAL.Singleton.getBillInfoByTableID(tableID);
            foreach(BillInfo item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.Totalprice.ToString());
                lsvBillInfo.Items.Add(lsvItem);
                totalPrice += item.Totalprice;
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }
        void loadComboboxTable(ComboBox cb)
        {
            List<Table> tableList = TableDAL.Singleton.tableList();
            cb.DataSource = tableList;
            cb.DisplayMember = "Name";
        }
        #endregion

        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            txbFocusTable.Text = tableID.ToString();
            lsvBillInfo.Tag = (sender as Button).Tag;
            showBill(tableID);
        }
        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAccount accInfo = new formAccount();
            accInfo.Show();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cateID = 0;
            ComboBox cb = sender as ComboBox;
            CategoryFood selectedItem = cb.SelectedItem as CategoryFood;
            cateID = selectedItem.Id;
            loadFoodByCategoryID(cateID);
        }
        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            Food selectedItem = cb.SelectedItem as Food;
            txbSelectedItem.Text = selectedItem.FoodName.ToString();
            txbSinglePrice.Text = selectedItem.Price.ToString();
        }
        private void cbSearchedItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            txbSelectedItem.Text = cb.SelectedItem.ToString();
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBillInfo.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Xin mời chọn bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int idBill = BillDAL.Singleton.getBillIDByTableID(table.Id);
                int idFood = (cbFood.SelectedItem as Food).Id;
                string foodName = (cbFood.SelectedItem as Food).FoodName;
                if (idBill == -1) //chưa có bill
                {
                    BillDAL.Singleton.insertBill(table.Id);
                    BillInfoDAL.Singleton.insertBillInfo(BillDAL.Singleton.getMaxBillID(), idFood, (int)nmQuantityFood.Value);
                    TableDAL.Singleton.changeStatus(BillDAL.Singleton.getMaxBillID());
                }
                else //đã có bill
                {
                    BillInfoDAL.Singleton.insertBillInfo(idBill, idFood, (int)nmQuantityFood.Value);
                    TableDAL.Singleton.changeStatus(idBill);
                }
                showBill(table.Id);
                buttonList[table.Id].Text = "Bàn " + table.Id + Environment.NewLine + "Có người";
                buttonList[table.Id].BackColor = Color.Pink;
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            Table table = lsvBillInfo.Tag as Table;
            int idBill = BillDAL.Singleton.getBillIDByTableID(table.Id);
            if (idBill != -1) //có bill
            {
                if(MessageBox.Show("Thanh toán?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    BillDAL.Singleton.checkOut(idBill);
                    TableDAL.Singleton.changeStatus(idBill);
                    showBill(table.Id);
                    buttonList[table.Id].BackColor = Color.Aqua;
                    buttonList[table.Id].Text = "Bàn " + table.Id + Environment.NewLine + "Trống";
                }
            }
        }
        private void btnSwapTable_Click(object sender, EventArgs e)
        {
            int idTable1 = int.Parse(txbFocusTable.Text);
            int idTable2 = (cbTableList.SelectedItem as Table).Id;
            if (buttonList[idTable1].Text == "Bàn "+idTable1+"\r\nCó người")
            {
                if (buttonList[idTable2].Text == "Bàn " + idTable2 + "\r\nCó người")
                {
                    MessageBox.Show("Bàn này đã có người, vui lòng chọn bàn khác. Xin cảm ơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TableDAL.Singleton.swapTable(idTable1, idTable2);
                    buttonList[idTable1].BackColor = Color.Aqua;
                    buttonList[idTable1].Text = "Bàn " + idTable1 + Environment.NewLine + "Trống";
                    buttonList[idTable2].BackColor = Color.Pink;
                    buttonList[idTable2].Text = "Bàn " + idTable2 + Environment.NewLine + "Có người";
                    showBill(idTable1);
                }
            }
            else
            {
                if (buttonList[idTable2].Text == "Bàn " + idTable2 + "\r\nCó người")
                {
                    MessageBox.Show("Bàn này đã có người, vui lòng chọn bàn khác. Xin cảm ơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion
    }
}
