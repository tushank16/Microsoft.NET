using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Day_18_Assignment
{
    class EmployeeLayer
    {
        public List<Employee> ListEmployees
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                List<Employee> Employee = new List<Employee>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("Select * from Employee", con);
                    con.Open();
                    Console.WriteLine("connected");
                    SqlDataReader rdr = cmd.ExecuteReader(); //returns object of sqldatareder
                    while (rdr.Read())
                    {
                        Employee emp = new Employee();
                        emp.Id = Convert.ToInt32(rdr["Id"]);
                        emp.Name = rdr["Name"].ToString();
                        emp.Salary = Convert.ToSingle(rdr["Salary"]);

                        Employee.Add(emp);
                    }
                    return Employee;
                }
            }
        }

        public int CountEmployees
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                int no = 0;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Select Count(Id) from Employee", con);
                        con.Open();
                        no = (int)cmd.ExecuteScalar();
                       
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    return no;
                }
            }
        }

        public double MaxSalary
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                double maxsal = 0;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "select max(Salary) from Employee";
                        cmd.Connection = con;
                        con.Open();
                        object sal = cmd.ExecuteScalar();
                       // Console.WriteLine("Maximum Salary : " + sal);
                        maxsal = (double)sal;
                    }
                   catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    return maxsal;
                }
            }
        }
    }
}
