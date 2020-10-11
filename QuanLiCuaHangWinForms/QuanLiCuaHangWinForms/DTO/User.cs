using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangWinForms.DTO
{
    public class User
    {
        public User(DataRow row)
        {
            this.id = Convert.ToInt32(row["ID"]);
            this.userName = row["UserName"].ToString();
            this.passWord = row["PassWord"].ToString();
            this.type = Convert.ToInt32(row["AccountType"]);
            this.name = row["Name"].ToString(); ;
            this.sex = row["Sex"].ToString(); ;
            this.age = Convert.ToInt32(row["Age"]);
            this.number = row["Number"].ToString();
            this.email = row["Email"].ToString();
            this.adress = row["Adress"].ToString();
        }
        public User(int id, string userName, string passWord, int type, string name, string sex, int age, string number, string email, string adress)
        {
            this.id = id;
            this.userName = userName;
            this.passWord = passWord;
            this.type = type;
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.number = number;
            this.email = email;
            this.adress = adress;
        }
        private int id;
        private string userName;
        private string passWord;
        private int type;
        private string name;
        private string sex;
        private int age;
        private string number;
        private string email;
        private string adress;

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }
        public string Number { get => number; set => number = value; }
        public string Email { get => email; set => email = value; }
        public string Adress { get => adress; set => adress = value; }
    }
}
