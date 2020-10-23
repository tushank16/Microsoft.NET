using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Assignment_ClassLibrary_Q2
{
    public class Employee 
    {
        private int Id;
        private string Name;
        private double Salary, netsalary;
        static double TDS = 0.10;
        static Employee()
        {
            Console.WriteLine("\nEmployee Class Developed by Tushank Shingte\n");
        }
        public Employee(int Id, string name, double Salary)
        {
            this.Id = Id;
            this.Name = name;
            this.Salary = Salary;
        }
        public void calculate_netsalary()
        {
            double netTDS = Salary * TDS;
            this.netsalary = Salary - netTDS;
            Console.WriteLine("Salary : {0}; NetSalart : {1}", Salary, netsalary);
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
