/*
using System;

namespace Day_18_Assignment
{
    class Q2_c
    {
        //Q2. c. DELETE employee record in database using ExecutenonQuery() method 

        static void Main(string[] args)
        {
            EmployeeLayer employee = new EmployeeLayer();
            var list = employee.ListEmployees;
            foreach (var a in list)
            {
                Console.WriteLine("{0}\t{1}\t{2}", a.Id, a.Name, a.Salary);
            }
            DeleteEmployee deleteEmployee = new DeleteEmployee();
            deleteEmployee.DeleteEmployeeByID(8);

            list = employee.ListEmployees;
            foreach (var a in list)
            {
                Console.WriteLine("{0}\t{1}\t{2}", a.Id, a.Name, a.Salary);
            }
        }
    }
}
*/