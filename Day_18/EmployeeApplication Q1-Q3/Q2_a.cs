/*
using System;

namespace Day_18_Assignment
{
    class Q2_a
    {
        //Q2. a. INSERT employee record in database using ExecutenonQuery() method 
        static void Main(string[] args)
        {
            InsertEmployee insert = new InsertEmployee();
            insert.Insert_Employee("Sanyog", 50000);

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