using System;
using System.Collections.Generic;

namespace Day_19_Assignment
{
    class Q1
    {
        //Q1. Create a table Employee having column  Id, Name, Salary.
        //    Create a class Employee having member Id, Name, Salary.
        //    Create a class BusinessLayer  and write two method 
        //    Public Employee search(int id)
        //    Public List<Employee>(string name)
        //    Above method will search the record and return results. Entry point class will display data.

        static void Main(string[] args)
        {

            Employee e1 = null;
            e1 = DisplayData.Search.search(2);
            Console.WriteLine("{0}\t{1}\t{2}", e1.Id, e1.Name, e1.Salary);
            Console.WriteLine("****************************************");


            List<Employee> List = new List<Employee>();
            List = DisplayData.Search.search("Tushank");
            foreach (var l in List)
            {
                Console.WriteLine("{0}\t{1}\t{2}", l.Id, l.Name, l.Salary);
            }
            Console.WriteLine("****************************************");

        }
    }
}
