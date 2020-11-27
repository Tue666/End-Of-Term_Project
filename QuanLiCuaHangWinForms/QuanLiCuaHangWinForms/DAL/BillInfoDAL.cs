using QuanLiCuaHangWinForms.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangWinForms.DAL
{
    public class BillInfoDAL
    {
        private static BillInfoDAL singleton;

        public static BillInfoDAL Singleton {
            get { if (singleton == null) singleton = new BillInfoDAL(); return singleton; } 
            private set => singleton = value; 
        }
        public bool checkExistFood(int foodID, int billID)
        {
            string query = "SELECT * FROM dbo.BillInFo WHERE idFood = " + foodID + " AND idBill = " + billID + "";
            return Convert.ToInt32(Database.Singleton.ExucuteScalar(query)) > 0;
        }
        public List<BillInfo> getBillInfoByTableID(int tableID)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            string query = "EXEC USP_ShowBill " + tableID;
            DataTable data = Database.Singleton.ExucuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BillInfo billInfo = new BillInfo(item);
                listBillInfo.Add(billInfo);
            }
            return listBillInfo;
        }
        public void insertBillInfo(int idBill, int idFood, int QuantityFood)
        {
            string query = "EXEC USP_InsertBillInfo @idBill , @idFood , @QuantityFood";
            Database.Singleton.ExucuteNonQuery(query,new object[]{ idBill, idFood, QuantityFood});
        }

    }
}
