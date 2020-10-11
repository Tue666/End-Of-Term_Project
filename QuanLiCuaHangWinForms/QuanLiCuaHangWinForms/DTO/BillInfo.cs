using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangWinForms.DTO
{
    public class BillInfo
    {
        public BillInfo(DataRow row)
        {
            this.name = row["FoodName"].ToString();
            this.quantity = Convert.ToInt32(row["QuantityFood"]);
            this.totalprice = Convert.ToDouble(row["TotalPrice"]);
        }
        public BillInfo(string name, int quantity, double totalprice)
        {
            this.name = name;
            this.quantity = quantity;
            this.totalprice = totalprice;
        }
        private string name;
        private int quantity;
        private double totalprice;

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Totalprice { get => totalprice; set => totalprice = value; }
    }
}
