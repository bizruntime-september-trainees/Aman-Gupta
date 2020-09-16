using System;
using System.Data.SqlClient;
using System.Data;
namespace AdoNetConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=ADODatabase1; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table studentCopy(id int not null,name varchar(100), email varchar(50), join_date date)", con);

               // SqlCommand cm1 = new SqlCommand("ïnsert into studentcopy values(1,'aman','amangupta99a@gmail.com','16-sep-2020')",con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}