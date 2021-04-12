using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GIU_DB_
{
    class Database
    {
        static SqlConnection conn;
        public static SqlConnection ConnectDB()
        {
            string connString = @"Server=LAPTOP-8DDGNA0F\SQLEXPRESS;Database=Course;Integrated Security=true;";
            conn = new SqlConnection(connString);
            return conn;
        }
    }
}