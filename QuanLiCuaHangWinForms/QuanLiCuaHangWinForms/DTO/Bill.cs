using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangWinForms.DTO
{
    public class Bill
    {
        public Bill(DataRow row)
        {
            this.id = Convert.ToInt32(row["ID"]);
            this.idTable = Convert.ToInt32(row["idTable"]);
            this.status = Convert.ToInt32(row["status"]);
        }
        public Bill(int id, int idTable, int status)
        {
            this.id = id;
            this.idTable = idTable;
            this.status = status;
        }
        private int id;
        private int idTable;
        private int status;

        public int Id { get => id; set => id = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public int Status { get => status; set => status = value; }
    }
}
