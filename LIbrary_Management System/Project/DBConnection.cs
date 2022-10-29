using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace LIbrary_Management_System.Project
{
    class DBConnection
    {
        const string connectionString = "server=HP\\SQLEXPRESS;Database=Library_System;Integrated Security = True";

        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                return con;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }

    }
}
