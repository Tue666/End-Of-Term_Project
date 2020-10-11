using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangWinForms.DTO
{
    public class Table
    {
        public Table(DataRow row)
        {
            this.id = Convert.ToInt32(row["id"]);
            this.name = row["TableName"].ToString();
            this.status = row["Status"].ToString();
        }
        public Table(int id, string name, string status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
        }
        private string status;
        private string name;
        private int id;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
    }
}
