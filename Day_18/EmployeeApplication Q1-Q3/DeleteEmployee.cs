using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Day_18_Assignment
{
    class DeleteEmployee
    {
        public void DeleteEmployeeByID(int id)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    string query = "Delete from Employee where Id = '" + id + "';";
                    Console.WriteLine(query);
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Updated Rows = " + rowsAffected + "<br/>");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
