using System;
using System.Data.SqlClient;

namespace ado_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Getting Connection ...");

            var datasource = @"DESKTOP-N2FDSD9\SQLEXPRESS"; // your server
            var database = "ADO_demo"; // your database name
            //var username = "DESKTOP-LCNNVH9\\kk"; // username of server to connect
            //var password = ""; // password

            // Create your connection string
            string connString = @"Data Source=" + datasource +
                ";Initial Catalog=" + database + "; Trusted_Connection=True;";


            Console.WriteLine(connString);

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                Console.WriteLine("Opening Connection ...");
                // Open the connection
                conn.Open();
                Console.WriteLine("Connection successful!");
                
                InsertStaff(conn);
                displayStaff(conn);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }


        }
        static void InsertStaff(SqlConnection conn)
        {
            int id = 1;
            string name = "John";
            string contact = "1234567890";
            string query = "insert into student values(@id,@name,@contact)";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@id", id);
            cm.Parameters.AddWithValue("@name", name);
            cm.Parameters.AddWithValue("@contact", contact);
            int rows = cm.ExecuteNonQuery();
            if (rows > 0)
            {
                Console.WriteLine("Inseted record successfully");
            }

        }
        static void displayStaff(SqlConnection conn)
        {
            string query = "select * from student";
            SqlCommand cm = new SqlCommand(query, conn);
            SqlDataReader reader = cm.ExecuteReader();
            Console.WriteLine("Staff :");
            while (reader.Read())
            {
                {
                    Console.WriteLine($"student_id :{reader["student_id"]} name :{reader["name"]} contact_no : {reader["contact_no"]}");
                }
            }
        }
    }
}
