using QuanLiCuaHangWinForms.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangWinForms.DAL
{
    public class BillDAL
    {
        private static BillDAL singleton;

        public static BillDAL Singleton { get { if (singleton == null) singleton = new BillDAL(); return singleton; } private set => singleton = value; }
    
        public int getBillIDByTableID(int tableID)
        {
            string query = "SELECT * FROM Bill WHERE idTable = " + tableID + " AND Status = 0";
            DataTable data = Database.Singleton.ExucuteQuery(query);
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }

            return -1;
        }

        public void insertBill(int tableID)
        {
            string query = "EXEC USP_InserBill @idTable";
            Database.Singleton.ExucuteNonQuery(query, new object[] { tableID });
        }

        public int getMaxBillID()
        {
            return (int)Database.Singleton.ExucuteScalar("SELECT MAX(ID) FROM Bill");
        }

        public void checkOut(int idBill)
        {
            string query = "EXEC USP_CheckOut @idBill";
            Database.Singleton.ExucuteNonQuery(query, new object[] { idBill});
        }
    }
}
