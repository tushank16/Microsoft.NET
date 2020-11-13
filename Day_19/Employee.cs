using System;

namespace Day_19_Assignment
{
    class Employee
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public float Salary { get; set; }

        public Employee(string nm, float sal)
        {
            this.Name = nm;
            this.Salary = sal;
        }
        public Employee() { }
    }
}
