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
            this.dayCheckIn = (DateTime?)row["DayCheckIn"];
            if (row["DayCheckOut"].ToString() != "")
                this.dayCheckOut = (DateTime?)row["DayCheckOut"];
        }
        public Bill(int id, int idTable, int status, DateTime? dayCheckIn, DateTime? dayCheckOut)
        {
            this.id = id;
            this.idTable = idTable;
            this.status = status;
            this.DayCheckIn = dayCheckIn;
            this.DayCheckOut = dayCheckOut;
        }
        private int id;
        private int idTable;
        private int status;
        private DateTime? dayCheckIn;
        private DateTime? dayCheckOut;

        public int Id { get => id; set => id = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public int Status { get => status; set => status = value; }
        public DateTime? DayCheckIn { get => dayCheckIn; set => dayCheckIn = value; }
        public DateTime? DayCheckOut { get => dayCheckOut; set => dayCheckOut = value; }
    }
}
