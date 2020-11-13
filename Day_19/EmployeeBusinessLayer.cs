
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Day_19_Assignment
{
    class EmployeeBusinessLayer
    {
        public SqlConnection getconnection()
        {
            SqlConnection sqlconn = new SqlConnection();
            string connstring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            sqlconn.ConnectionString = connstring;
            return sqlconn;
        }

        public Employee search(int id)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            Employee e = null;
            try
            {
                sqlconn = getconnection();
                sqlconn.Open();
                string querry = "select * from Employee where id=@pid";
                Console.WriteLine(querry);
                sqlcmd = new SqlCommand(querry, sqlconn);
                sqlcmd.Parameters.AddWithValue("@pid", id);
                SqlDataReader rd = sqlcmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        e = new Employee();
                        e.Id = Convert.ToInt32(rd["Id"]);
                        e.Name = rd["Name"].ToString();
                        e.Salary = Convert.ToSingle(rd["Salary"]);
                        break;
                    }
                 }       
             }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {
                sqlconn.Close();
                sqlconn = null;
            }
            return e;
        }
        public List<Employee> search(string name)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            List<Employee> List = new List<Employee>();
            try
            {
                sqlconn = getconnection();
                sqlconn.Open();
                string querry = "select * from Employee where Name=@pname";
                Console.WriteLine(querry);
                sqlcmd = new SqlCommand(querry, sqlconn);
                sqlcmd.Parameters.AddWithValue("@pname", name);
                SqlDataReader rd = sqlcmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        Employee e = new Employee();
                        e.Id = Convert.ToInt32(rd["Id"]);
                        e.Name = rd["Name"].ToString();
                        e.Salary = Convert.ToSingle(rd["Salary"]);
                        List.Add(e);
                    }
                }
            }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {
                sqlconn.Close();
                sqlconn = null;
            }
            return List;
        }

        public void insert(Employee e)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            int record = 0;
            try
            {
                sqlconn = getconnection();
                sqlcmd = new SqlCommand("insertEmployee", sqlconn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@ename", SqlDbType.NVarChar).Value = e.Name;
                sqlcmd.Parameters.AddWithValue("@esalary", SqlDbType.Float).Value = e.Salary;            
                sqlconn.Open();
                record = sqlcmd.ExecuteNonQuery();
                Console.WriteLine("Data Added Successfully " +record);
            }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {
                sqlconn.Close();
                sqlconn = null;
            }
        }

        public void updateNameUsingId(int id, string name)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            int record = 0;
            try
            {
                sqlconn = getconnection();
                sqlcmd = new SqlCommand("updateEmpNameById", sqlconn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@ename", SqlDbType.NVarChar).Value = name;
                sqlcmd.Parameters.AddWithValue("@eid", SqlDbType.Int).Value = id;
                sqlconn.Open();
                record = sqlcmd.ExecuteNonQuery();
                Console.WriteLine("Data Updated Successfully " + record);
            }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {
                sqlconn.Close();
                sqlconn = null;
            }
        }

        public List<Employee> Display()
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            List<Employee> List = new List<Employee>();
            try
            {
                sqlconn = getconnection();
                sqlconn.Open();
                string querry = "select * from Employee";
                Console.WriteLine(querry);
                sqlcmd = new SqlCommand(querry, sqlconn);
                SqlDataReader rd = sqlcmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        Employee e = new Employee();
                        e.Id = Convert.ToInt32(rd["Id"]);
                        e.Name = rd["Name"].ToString();
                        e.Salary = Convert.ToSingle(rd["Salary"]);
                        List.Add(e);
                    }
                }
            }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {
                sqlconn.Close();
                sqlconn = null;
            }
            return List;
        }
    }
}
