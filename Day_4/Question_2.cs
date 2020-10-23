using System;
using Day_4_Assignment_ClassLibrary_Q2;

namespace Day_4_Assignment
{
    class Question_2
    {
        static void Main(string[] args)
        {
            //Q2.   Create a class Employee having private instance member Id, Name Salary, netsalary.
            //      Create method calculate_netsalary who’s job is to deduct 10% of TDS.. Write method display which will display name and netsalary.
            //      This application will be classlibrary.
            //      Create console application and use this class library. Create at least two object of Employee class 
            Employee emp1 = new Employee(1, "Tushank", 9000.0);
            emp1.calculate_netsalary();
            emp1.display();
            Employee emp2 = new Employee(1, "Shashank", 100000.0);
            emp2.calculate_netsalary();
            emp2.display();
        }
    }
}