using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Day_18_Assignment
{
    class UpdateEmployee
    {
        public void Update_EmployeeNameByID(int id, string Name)
        {           
            string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    string query = "update Employee set name = '" + Name + "' where Id = '" + id + "';";
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

        public void Update_EmployeeSalaryByID(int id, float Salary)
        {
            float sal = (float)Salary;
            string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    string query = "update Employee set salary = " + sal + " where Id = '" + id + "';";
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
