using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Day_18_Assignment
{
    class InsertEmployee
    {
        public void Insert_Employee(string Name, float Salary)
        {
            string nm = (string)Name;
            float sal = (float)Salary;
            string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into Employee values ('"+nm+"',"+ sal+")", connection);
                    connection.Open();                 
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Inserted Rows = " + rowsAffected + "<br/>");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
