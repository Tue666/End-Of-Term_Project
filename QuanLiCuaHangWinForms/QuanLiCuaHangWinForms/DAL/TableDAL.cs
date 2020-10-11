using QuanLiCuaHangWinForms.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangWinForms.DAL
{
    public class TableDAL
    {
        public static int TableW = 105;
        public static int TableH = 78;

        private static TableDAL singleton;

        public static TableDAL Singleton {
            get { if (singleton == null) singleton = new TableDAL(); return singleton; }
            private set => singleton = value;
        }

        public TableDAL() { }

        public List<Table> tableList()
        {
            List<Table> tablelist = new List<Table>();
            string query = "SELECT * FROM dbo.TableFood";
            DataTable data = Database.Singleton.ExucuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
        public void changeStatus(int idBill)
        {
            string query = "USP_TableList @idBill";
            Database.Singleton.ExucuteNonQuery(query, new object[] { idBill});
        }
        public void swapTable(int idTable1, int idTable2)
        {
            string query = "USP_SwapTable @idTable1 , @idTable2";
            Database.Singleton.ExucuteNonQuery(query, new object[] { idTable1, idTable2 });
        }
    }
}
