using QuanLiCuaHangWinForms.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangWinForms.DAL
{
    public class CategoryFoodDAL
    {
        private static CategoryFoodDAL singleton;

        public static CategoryFoodDAL Singleton { get { if (singleton == null) singleton = new CategoryFoodDAL(); return singleton; }private set => singleton = value; }
        
        public List<CategoryFood> listCateFood()
        {
            List<CategoryFood> listCateFood = new List<CategoryFood>();
            string query = "SELECT * FROM FoodCategory";
            DataTable data = Database.Singleton.ExucuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                CategoryFood cateFood = new CategoryFood(item);
                listCateFood.Add(cateFood);
            }
            return listCateFood;
        }
    }
}
