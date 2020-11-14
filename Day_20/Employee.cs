using System;

namespace Day_20_Assignnment
{
    class Employee
    {
        public static int EmpId;
        public int Id { get; set; }
        public string Name{ get; set; }
        public float Salary { get; set; }

        public Employee(string nm, float sal)
        {
            this.Id = ++EmpId;
            this.Name = nm;
            this.Salary = sal;
        }

        public Employee() { }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}",Id, Name, Salary);
        }
    }
}
