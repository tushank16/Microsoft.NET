using System;

namespace Day_5_Assignment_ClassLibrary_Q3
{
    public class Employee
    {
        private static int empid = 1;
        static double TDS = 0.10;

        private const int maxemp = 3;
        private const int maxsal = 50000;

        private int Id;
        private string Name;
        private double Salary, netsalary;

        static Employee()
        {
            Console.WriteLine("\nEmployee Class Developed by Tushank Shingte\n");
        }

        public Employee(string name, double Salary)
        {
            if (empid > maxemp || Salary > maxsal)
            {
                if (empid > maxemp)
                {
                    Console.WriteLine("Employee cannot be more than " + maxemp);
                }
                if (Salary > maxsal)
                {
                    Console.WriteLine("Salary cannot be greater than " + maxsal);
                }
                Console.WriteLine("Object cannot be created");
            }
            else
            {
                this.Id = empid;
                empid++;
                this.Name = name;
                this.Salary = Salary;
            }
        }

        public void calculate_netsalary()
        {
            double netTDS = Salary * TDS;
            this.netsalary = Salary - netTDS;
            Console.WriteLine("Calculating net Salary \nSalary : {0}; NetSalart : {1}", Salary, netsalary);
        }

        public void display()
        {
            if (this.netsalary == 0)
            {
                Console.WriteLine("Calculate NetSalary first");
            }
            else
            {
                Console.WriteLine("Id : {0}; Name : {1}; NetSalart : {2}", Id, Name, netsalary);
            }
        }
    }
}
