using QuanLiCuaHangWinForms.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangWinForms.DAL
{
    public class AccountDAL
    {
        public static int Id;
        public static string UserName;
        public static string PassWord;
        public static int Type;

        private static AccountDAL singleton;

        public static AccountDAL Singleton {
            get { if (singleton == null) singleton = new AccountDAL(); return AccountDAL.singleton; }
            private set => singleton = value; }
        
        private AccountDAL() { }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM dbo.Account WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "'";
            DataTable data = Database.Singleton.ExucuteQuery(query);
            if (data.Rows.Count == 1)
            {
                string queryID = "SELECT ID FROM dbo.Account WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "'";
                Id = (int)Database.Singleton.ExucuteScalar(queryID);
                Type = Convert.ToInt32(data.Rows[0]["AccountType"]);
            }
            UserName = userName;
            PassWord = passWord;
            return data.Rows.Count == 1;
        }
        public User getInforUser(string userName, string passWord)
        {
            string query = "SELECT * FROM dbo.Account WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "'";
            User user = new User(Database.Singleton.ExucuteQuery(query).Rows[0]);
            return user;
        }
        public DataTable loadDataAccount()
        {
            string query = "SELECT * FROM dbo.Account";
            return Database.Singleton.ExucuteQuery(query);
        }
        public void insertUser(string userName, string passWord, int Type, string name = "", string sex = "", int age = 0, string number = "", string email = "", string adress = "")
        {
            string query = "INSERT dbo.Account VALUES (N'" + userName + "',N'" + passWord + "', " + Type + ",N'" + name + "',N'" + sex + "'," + age + ",N'" + number + "',N'" + email + "',N'" + adress + "')";
            Database.Singleton.ExucuteNonQuery(query);
        }
        public void deleteUser(int userID)
        {
            string query = "DELETE dbo.Account WHERE ID = " + userID;
            Database.Singleton.ExucuteNonQuery(query);
        }
        public void editUser(int userID, string userName, string passWord, int Type, string name = "", string sex = "", int age = 0, string number = "", string email = "", string adress = "")
        {
            string query = "UPDATE dbo.Account SET UserName = N'" + userName + "', PassWord = N'" + passWord + "', AccountType = " + Type + ", Name = N'" + name + "', Sex = N'" + sex + "',Age = " + age + ",Number = N'" + number + "',Email = N'" + email + "',Adress = N'" + adress + "' WHERE ID = " + userID;
            Database.Singleton.ExucuteNonQuery(query);
        }
        public void updatePass(int userID, string newPass)
        {
            string query = "UPDATE dbo.Account SET PassWord = N'" + newPass + "' WHERE ID = " + userID;
            Database.Singleton.ExucuteNonQuery(query);
        }
        public List<User> searchUser(string userName)
        {
            List<User> listUser = new List<User>();
            string query = "SELECT * FROM dbo.Account WHERE dbo.ChuyenTiengVietCoDauThanhKhongDau(UserName) LIKE N'%'+dbo.ChuyenTiengVietCoDauThanhKhongDau(N'" + userName + "')+'%'";
            DataTable data = Database.Singleton.ExucuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                User user = new User(item);
                listUser.Add(user);
            }
            return listUser;
        }
    }
}
