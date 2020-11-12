using System;

namespace Day_18_Assignment
{
    class Q3
    {
        //Q3. Use aggregate function ie. Print max salary and count number of employee in database
        static void Main(string[] args)
        {
            EmployeeLayer emp = new EmployeeLayer();
            int count = emp.CountEmployees;
            Console.WriteLine("Total No of Employees : " + count);

            double MaxSalary = emp.MaxSalary;
            Console.WriteLine("Maximum Salary of Employees : " + MaxSalary);

        }
    }
}
