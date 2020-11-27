using QuanLiCuaHangWinForms.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangWinForms.DAL
{
    public class FoodDAL
    {
        private static FoodDAL singleton;

        public static FoodDAL Singleton { get { if (singleton == null) singleton = new FoodDAL(); return singleton; } private set => singleton = value; }

        public int getFoodIDByFoodName(string foodName)
        {
            string query = "SELECT ID FROM dbo.Food WHERE FoodName = N'" + foodName + "'";
            return Convert.ToInt32(Database.Singleton.ExucuteScalar(query));
            
        }
        public List<Food> listFoodByCateID(int cateID)
        {
            List<Food> listFood = new List<Food>();
            string query = "SELECT * FROM Food WHERE FoodCategory = " + cateID;
            DataTable data = Database.Singleton.ExucuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood.Add(food);
            }
            return listFood;
        }
        public DataTable loadComboboxFoodCate()
        {
            string query = "SELECT * FROM dbo.FoodCategory";
            return Database.Singleton.ExucuteQuery(query);
        }
        public DataTable loadDataFood()
        {
            string query = "SELECT f.ID AS [Mã thức ăn],f.FoodName AS [Tên món ăn],fc.CategoryName AS [Loại],f.Price AS [Đơn giá]" +
                " FROM dbo.Food AS f, dbo.FoodCategory AS fc" +
                " WHERE f.FoodCategory = fc.ID";
            return Database.Singleton.ExucuteQuery(query);
        }
        public void insertFood(string foodName, string foodCateName, float price)
        {
            string query = "INSERT dbo.Food VALUES (N'" + foodName + "',(SELECT ID FROM dbo.FoodCategory WHERE CategoryName = N'" + foodCateName + "' ), " + price + ")";
            Database.Singleton.ExucuteNonQuery(query);
        }
        public void deleteFood(int foodID)
        {
            string query = "DELETE dbo.Food WHERE ID = " + foodID;
            Database.Singleton.ExucuteNonQuery(query);
        }
        public void editFood(int foodID, string foodName, string foodCateName, float price)
        {
            string query = "UPDATE dbo.Food SET FoodName = N'" + foodName + "', FoodCategory = (SELECT ID FROM dbo.FoodCategory WHERE CategoryName = N'" + foodCateName + "'), Price = " + price + " WHERE ID = " + foodID;
            Database.Singleton.ExucuteNonQuery(query);
        }
        public List<Food> searchFood(string foodName)
        {
            List<Food> listFood = new List<Food>();
            string query = "SELECT * FROM dbo.Food WHERE dbo.ChuyenTiengVietCoDauThanhKhongDau(FoodName) LIKE N'%'+dbo.ChuyenTiengVietCoDauThanhKhongDau(N'" + foodName + "')+'%'";
            DataTable data = Database.Singleton.ExucuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listFood.Add(food);
            }
            return listFood;
        }
    }
}
