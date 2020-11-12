/*using System;

namespace Day_18_Assignment
{
    class Q1
    {
        //Q1. Create a table Employee having column  Id, Name, Salary.
        //    Create a class Employee having member Id, Name, Salary.
        //    Create a class BusinessLayer with a getter method who’s
        //    job is to return list of the employee retrieved from database and map to the class Employee.
        static void Main(string[] args)
        {
            EmployeeLayer employee = new EmployeeLayer();
            var list = employee.ListEmployees;
            foreach (var a in list)
            {
                Console.WriteLine("{0}\t{1}\t{2}", a.Id, a.Name, a.Salary);
            }
        }
    }
}
*/