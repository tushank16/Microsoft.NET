using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Day_20_Assignnment
{
    class EmployeeData_Adapter
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        SqlConnection Con ;
        SqlDataAdapter dataAdapter; 
        DataSet dataset = new DataSet();

        public void DisplayEmployee()
        {
            Con = new SqlConnection(ConnectionString);
            dataAdapter = new SqlDataAdapter("SELECT * FROM EMPLOYEE", Con);
            dataAdapter.FillSchema(dataset, SchemaType.Source, "Employee");
            dataAdapter.Fill(dataset, "Employee");
            DataTable dt = dataset.Tables["Employee"];
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                    Console.Write(row[col] + " ");
                Console.WriteLine("\n----------------------------------");
            }

        }

        public void Insert(Employee emp)
        {
           
            string name = emp.Name;
            float salary = emp.Salary;
            DataRow drCurrent = dataset.Tables["Employee"].NewRow();
            drCurrent["Name"] = name;
            drCurrent["Salary"] = salary;

            dataset.Tables["Employee"].Rows.Add(drCurrent);
            Console.WriteLine("Add was successful, Click any key to continue!!");

            SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataset, "Employee");
            Console.WriteLine(co.GetInsertCommand().CommandText);

        }

        public void UpdateNameById(int id, string nm)
        {
            string name = nm;
            DataRow update = dataset.Tables["Employee"].Rows.Find(id);
            update["Name"] = name;

            SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataset, "Employee");
            Console.WriteLine(co.GetInsertCommand().CommandText);

        }

        public void UpdateSalaryById(int id, float sal)
        {
            float salary = sal;
            DataRow update = dataset.Tables["Employee"].Rows.Find(id);
            update["Salary"] = salary;

            SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataset, "Employee");
            Console.WriteLine(co.GetInsertCommand().CommandText);

        }

        public void DeletebyId(int id)
        {
            DataRow delete = dataset.Tables["Employee"].Rows.Find(id);
            delete.Delete();

            SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataset, "Employee");
            Console.WriteLine(co.GetInsertCommand().CommandText);

        }

    }
}
