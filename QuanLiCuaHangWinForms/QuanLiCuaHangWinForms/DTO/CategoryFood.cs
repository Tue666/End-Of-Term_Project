using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangWinForms.DTO
{
    public class CategoryFood
    {
        public CategoryFood(DataRow row)
        {
            this.id = Convert.ToInt32(row["ID"]);
            this.cateName = row["CategoryName"].ToString();
        }
        public CategoryFood(int id, string cateName)
        {
            this.id = id;
            this.cateName = cateName;
        }
        private int id;
        private string cateName;

        public int Id { get => id; set => id = value; }
        public string CateName { get => cateName; set => cateName = value; }
    }
}
