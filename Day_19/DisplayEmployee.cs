using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Day_19_Assignment
{
     class  DisplayEmployee
    {
        DataSet dataset;
        string ConnectionString = null;
        SqlConnection connection;
        public void Display()
        {

            SqlDataAdapter dataAdapter;
            ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            connection = new SqlConnection(ConnectionString);

            dataAdapter = new SqlDataAdapter("select * from Employee", connection);
            dataset = new DataSet();
            dataAdapter.FillSchema(dataset, SchemaType.Source, "emp");
            dataAdapter.Fill(dataset, "emp");
            DataTable dt = dataset.Tables["emp"];
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                    Console.Write(row[col] + " ");
                Console.WriteLine("\n----------------------------------");
            }
            
        }
    }
}
