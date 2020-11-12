using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Day_18_Product_Application
{
    class ProductLayer
    {
        public void displayproduct(string pname)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {  
                    SqlCommand cmd = new SqlCommand("Select * from Product where Name like '" + pname + "%'", connection);
                    connection.Open();
                    SqlDataReader rd=   cmd.ExecuteReader();
                    while (rd.Read())
                                Console.WriteLine("{0} {1} {2} {3}", rd["Id"], rd["Name"], rd["Price"],rd["Qty"]);
                }
                     
                catch(Exception ex)
                {
                Console.Write(ex.Message);
                }
            }                             
        }
        public void displayproductParameterisedQuerry(string pname)
        {
             string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
               using (SqlConnection connection = new SqlConnection(ConnectionString))
               {
                   try
                   {
                       // Parameterized query. @ProductName is the parameter
                       string Command = "Select * from Product where Name like @ProductName";
                       SqlCommand cmd = new SqlCommand(Command, connection);
                       // Provide the value for the parameter
                       cmd.Parameters.AddWithValue("@ProductName", pname + "%");
                       connection.Open();
                    SqlDataReader rd=   cmd.ExecuteReader();
                        while (rd.Read())
                        {
                        Console.WriteLine("{0} {1} {2} {3}", rd["Id"], rd["Name"], rd["Price"],rd["Qty"]);
                        }
                   }
                   catch (Exception ex)
                   {
                       Console.WriteLine(ex.Message );
                   }
               }
        }
        public void displayproductstoredprocedure(string pname)
        {           
           string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
           using (SqlConnection con = new SqlConnection(ConnectionString))
           {   
               SqlCommand cmd = new SqlCommand("spGetProductsByName", con);
               cmd.CommandType = System.Data.CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@ProductName", pname);
               try
               {
                   con.Open();
                   SqlDataReader rd = cmd.ExecuteReader();
                   while (rd.Read())
                   {
                       Console.WriteLine("{0} {1} {2} {3}", rd["Id"], rd["Name"], rd["Price"], rd["Qty"]);
                   }
               }
               catch (Exception ex)
               {
                   Console.WriteLine(ex.Message);
               }
           }          
        }
    }
}
