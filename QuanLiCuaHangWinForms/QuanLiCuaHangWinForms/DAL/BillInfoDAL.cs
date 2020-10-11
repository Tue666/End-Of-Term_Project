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

        public List<BillInfo> getBillInfoByTableID(int tableID)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            string query = "SELECT f.FoodName, bi.QuantityFood, f.Price*bi.QuantityFood AS TotalPrice FROM BillInFo AS bi, Bill AS b, Food AS f WHERE bi.idBill = b.ID AND bi.idFood = f.ID AND b.idTable = " + tableID + " AND b.Status = 0";
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
