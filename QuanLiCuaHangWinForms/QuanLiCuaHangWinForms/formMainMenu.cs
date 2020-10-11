using DevComponents.DotNetBar;
using DevComponents.WinForms.Drawing;
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
using DevComponents.DotNetBar.Rendering;

namespace QuanLiCuaHangWinForms
{
    public partial class formMainMenu : Form
    {
        public formMainMenu()
        {
            InitializeComponent();
            btnHello.Text = "Designed by 9hT | Xin chào " + AccountDAL.NameAccount + "!";
            if (AccountDAL.Type == 1)
            {
                rbTAdmin.Visible = true;
            }
            formIntroduce fIntro = new formIntroduce();
            fIntro.FormBorderStyle = FormBorderStyle.None;
            loadTab(fIntro,"Giới thiệu");
        }

        #region Methods
        bool checkTab(string tabName)
        {
            for (int i = 0; i < tMenu.Tabs.Count; i++)
            {
                if (tMenu.Tabs[i].Text == tabName)
                {
                    tMenu.SelectedTab = tMenu.Tabs[i];
                    return true;
                }
            }
            return false;
        }
        void loadTab(Form f, string tabName)
        {
            if (checkTab(tabName) == false)
            {
                TabItem tab = tMenu.CreateTab(tabName);
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                tab.AttachedControl.Controls.Add(f);
                f.Show();
                tMenu.SelectedTab = tab;
            }
        }
        #endregion

        #region Events
        private void btnInfo_Click(object sender, EventArgs e)
        {
            formAccount fAccount = new formAccount();
            fAccount.FormBorderStyle = FormBorderStyle.None;
            loadTab(fAccount, "Thông tin");
        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            formTable fTable = new formTable();
            fTable.FormBorderStyle = FormBorderStyle.None;
            loadTab(fTable, "Bàn ăn");
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBlackColor_Click(object sender, EventArgs e)
        {
            rbCMenu.Office2007ColorTable = eOffice2007ColorScheme.Black;
            tMenu.Style = eTabStripStyle.Office2007Document;
        }

        private void btnSilverColor_Click(object sender, EventArgs e)
        {
            rbCMenu.Office2007ColorTable = eOffice2007ColorScheme.Silver;
            tMenu.Style = eTabStripStyle.VS2005Dock;
        }

        private void btnBlueColor_Click(object sender, EventArgs e)
        {
            rbCMenu.Office2007ColorTable = eOffice2007ColorScheme.Blue;
            tMenu.Style = eTabStripStyle.OneNote;
        }

        private void btnVigataColor_Click(object sender, EventArgs e)
        {
            rbCMenu.Office2007ColorTable = eOffice2007ColorScheme.VistaGlass;
            tMenu.Style = eTabStripStyle.VS2005Dock;
        }
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hiện tại đang không có chương trình khuyến mãi nào :D", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            formUsers fAdmin = new formUsers();
            fAdmin.TopMost = false;
            fAdmin.Dock = DockStyle.Fill;
            loadTab(fAdmin, "Admin");
            fAdmin.FormBorderStyle = FormBorderStyle.None;
        }
        private void btnFood_Click(object sender, EventArgs e)
        {
            formFoods fFood = new formFoods();
            fFood.TopMost = false;
            fFood.Dock = DockStyle.Fill;
            loadTab(fFood, "Thức ăn");
            fFood.FormBorderStyle = FormBorderStyle.None;
        }
        #endregion
    }
}
