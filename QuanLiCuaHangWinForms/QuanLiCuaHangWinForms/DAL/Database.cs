using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHangWinForms.DAL
{
    public class Database
    {
        private static Database singleton;

        public static Database Singleton { 
            get { if (singleton == null) singleton = new Database(); return Database.singleton; } 
            private set => singleton = value; 
        }

        private Database() { }

        private string connectionString = @"Data Source=.\MSSQL_EXP_2014;Initial Catalog=QuanLiCafe;Integrated Security=True";
        public DataTable ExucuteQuery(string query, object[] para = null)  // trả về table
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        public int ExucuteNonQuery(string query, object[] para = null)  // trả về số dòng thành công
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }

        public object ExucuteScalar(string query, object[] para = null)  // trả về ô đầu tiên của kết quả
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
