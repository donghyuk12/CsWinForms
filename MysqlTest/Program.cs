using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MysqlTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string host = "localhost";
            int port = 3306;
            string database = "world";
            string uid = "root";
            string pwd = "1234";
            string connStr = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", host, port, database, uid, pwd);
        using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM country";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader table = cmd.ExecuteReader();

                    while (table.Read())
                    {
                        Console.WriteLine("[{0}] {1, -45} :  {2, 12:N0}", table["code"], table["name"], table["population"]);
                    }
                    table.Close();                     
                }
                catch(Exception exp)
                {
                    Console.WriteLine("Connection 실패");
                }
                connection.Close();
            }
        }
    }
}
