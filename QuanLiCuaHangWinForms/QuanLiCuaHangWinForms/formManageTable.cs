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
    public partial class formManageTable : Form
    {
        public formManageTable()
        {
            InitializeComponent();
            loadStatusTable();
        }

        #region Methods
        private void loadStatus(Label label, Button button, PictureBox picture)
        {
            string[] tableName = label.Text.Split(' ');
            int tableID = Convert.ToInt32(tableName[tableName.Length - 1]);
            string statusTable = TableDAL.Singleton.getStatusTable(tableID);
            if (statusTable == "Bảo trì")
            {
                picture.Image = new Bitmap(Application.StartupPath + "\\table4.png");
                button.Text = "Mở";
            }
            else
            {
                picture.Image = new Bitmap(Application.StartupPath + "\\table3.png");
                button.Text = "Khóa";
            }
        }
        private void loadStatusTable()
        {
            loadStatus(lbTable1, btnTable1, pcTable1);
            loadStatus(lbTable2, btnTable2, pcTable2);
            loadStatus(lbTable3, btnTable3, pcTable3);
            loadStatus(lbTable4, btnTable4, pcTable4);
            loadStatus(lbTable5, btnTable5, pcTable5);
            loadStatus(lbTable6, btnTable6, pcTable6);
            loadStatus(lbTable7, btnTable7, pcTable7);
            loadStatus(lbTable8, btnTable8, pcTable8);
        }
        private void changeStatusTable(Label label, Button button, PictureBox picture)
        {
            string[] tableName = label.Text.Split(' ');
            int tableID = Convert.ToInt32(tableName[tableName.Length - 1]);
            string statusTable = TableDAL.Singleton.getStatusTable(tableID);
            if (statusTable == "Có người")
            {
                MessageBox.Show("Bàn đang có người", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (button.Text == "Khóa")
                {
                    picture.Image = new Bitmap(Application.StartupPath + "\\table4.png");
                    button.Text = "Mở";
                }
                else
                {
                    picture.Image = new Bitmap(Application.StartupPath + "\\table3.png");
                    button.Text = "Khóa";
                }
                TableDAL.Singleton.changeMaintenance(tableID);
            }
        }
        #endregion

        #region Events
        private void btnTable1_Click_1(object sender, EventArgs e)
        {
            changeStatusTable(lbTable1, btnTable1, pcTable1);
        }
        private void btnTable2_Click(object sender, EventArgs e)
        {
            changeStatusTable(lbTable2, btnTable2, pcTable2);
        }
        private void btnTable3_Click(object sender, EventArgs e)
        {
            changeStatusTable(lbTable3, btnTable3, pcTable3);
        }
        private void btnTable4_Click(object sender, EventArgs e)
        {
            changeStatusTable(lbTable4, btnTable4, pcTable4);
        }
        private void btnTable5_Click(object sender, EventArgs e)
        {
            changeStatusTable(lbTable5, btnTable5, pcTable5);
        }
        private void btnTable6_Click(object sender, EventArgs e)
        {
            changeStatusTable(lbTable6, btnTable6, pcTable6);
        }
        private void btnTable7_Click(object sender, EventArgs e)
        {
            changeStatusTable(lbTable7, btnTable7, pcTable7);
        }
        private void btnTable8_Click(object sender, EventArgs e)
        {
            changeStatusTable(lbTable8, btnTable8, pcTable8);
        }
        #endregion
    }
}
