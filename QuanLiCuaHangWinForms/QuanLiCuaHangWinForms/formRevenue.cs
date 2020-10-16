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
    public partial class formRevenue : Form
    {
        public formRevenue()
        {
            InitializeComponent();
            loadDateTimeInput();
            showAllBill(dtICheckIn.Value, dtICheckOut.Value);
        }

        #region Methods
        private void loadDateTimeInput()
        {
            DateTime today = DateTime.Now;
            dtICheckIn.Value = new DateTime(today.Year, today.Month, 1);
            dtICheckOut.Value = dtICheckIn.Value.AddMonths(1).AddDays(-1);
        }
        private void showAllBill(DateTime? dayCheckIn, DateTime? dayCheckOut)
        {
            dgvSales.DataSource = BillDAL.Singleton.showAllBill(dayCheckIn, dayCheckOut);
        }
        #endregion

        #region Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            showAllBill(dtICheckIn.Value, dtICheckOut.Value);
        }
        #endregion
    }
}
