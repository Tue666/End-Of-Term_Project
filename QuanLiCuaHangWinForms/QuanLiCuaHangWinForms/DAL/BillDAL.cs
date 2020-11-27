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

        public float getAllDiscount(int idBill)
        {
            float result = 0;
            string query = "SELECT * FROM dbo.BillInFo WHERE idBill = " + idBill;
            DataTable data = Database.Singleton.ExucuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                int idFood = Convert.ToInt32(item["idFood"].ToString());
                string newQuery = "SELECT Discount FROM dbo.Food WHERE ID = " + idFood;
                result = result + (float)Convert.ToDouble(Database.Singleton.ExucuteScalar(newQuery));
            }

            return result;
        }
        public DataTable showAllBill(DateTime? dayCheckIn, DateTime? dayCheckOut)
        {
            string query = "SELECT tf.TableName AS [Bàn], b.allDiscount AS [Tổng khuyến mãi], b.totalPrice AS [Tổng tiền], b.DayCheckIn AS [Ngày vào], b.DayCheckOut AS [Ngày ra], b.Status AS [Tình trạng] FROM dbo.Bill AS b, dbo.TableFood AS tf WHERE b.idTable = tf.ID AND b.DayCheckIn >= '" + dayCheckIn.ToString() + "' AND b.DayCheckOut <= '" + dayCheckOut.ToString() + "' AND b.Status = 1";
            DataTable data = Database.Singleton.ExucuteQuery(query);
            return data;
        }
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

        public void checkOut(int idBill, float totalPrice, float allDiscount)
        {
            string query = "EXEC USP_CheckOut @idBill , @totalPrice , @allDiscount";
            Database.Singleton.ExucuteNonQuery(query, new object[] { idBill, totalPrice, allDiscount});
        }
    }
}
