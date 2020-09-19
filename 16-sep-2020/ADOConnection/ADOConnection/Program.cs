using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ADOConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            String connString;
            connString = ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;

            //create sql Connection object
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            Console.WriteLine("Connection to databse successful");
           //// SqlCommand cmd = new SqlCommand("select * from StudentTable",sqlConne
            ////Console.WriteLine(cmd);
            Console.ReadLine();

            sqlConnection.Close();
        }
    }
}
