﻿using System;
using Day_5_Assignment_ClassLibrary_Q3;
namespace Day_5_Assignment
{
    class Q3
    {
        static void Main(string[] args)
        {
        //Q3. Create a class Employee having private instance member Id, Name, Salary, netsalary.
        //    Id should be generated by application Create method calculate_netsalary who’s job is to deduct 10% of TDS.
        //    Declare TDS as static variable. Write method display which will display name and netsalary.
        //    This application will be classlibrary. Declare const int maxemp=3 ie. You can have only 3 employee.
        //    Also declare const int maxsal=50000.
        //    Use this for validation in constructor if you try to create object with salary 80000 it should display error

            Employee Ref1 = new Employee("Tushank", 80000.0);
            Ref1.calculate_netsalary();
            Ref1.display();

            Employee Ref2 = new Employee("Shashank", 35000.0);
            Ref2.calculate_netsalary();
            Ref2.display();

            Employee Ref3 = new Employee("Ojas", 40000.0);
            Ref3.calculate_netsalary();
            Ref3.display();

            Employee Ref4 = new Employee("Nihir", 45000.0);
            Ref4.calculate_netsalary();
            Ref4.display();

            Employee Ref5 = new Employee("Shriraj", 42000.0);
            Ref5.calculate_netsalary();
            Ref5.display();
        }
    }
}