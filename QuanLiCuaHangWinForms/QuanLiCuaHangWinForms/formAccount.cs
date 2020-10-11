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
    public partial class formAccount : Form
    {
        public formAccount()
        {
            InitializeComponent();
            txbUserID.Text = AccountDAL.Id.ToString();
            txbUserName.Text = AccountDAL.NameAccount;
            txbUserNumber.Text = "0968366601";
            txbUserEmail.Text = "lmht292001@gmail.com";
            txbAdress.Text = "Tp.HCM - Việt Nam :D";
        }
        #region Methods
        #endregion

        #region Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        #endregion
    }
}
