using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Assignment_ClassLibrary_Q1
{
    public class Employee
    {
        public String Firstname, Lastname, Middlename;

        public Employee(String Firstname, String Lastname)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Middlename = "";
        }
        public Employee(String Firstname, String Lastname, String Middlename)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Middlename = Middlename;
        }
        public void display()
        {
            Console.WriteLine("BaseType " + GetType().BaseType);
            Console.WriteLine("Type " + GetType());
            Console.WriteLine("Firstname: {0}; Lastname {1}; Middlename: {2} \n", Firstname, Lastname, Middlename);
        }
    }
}
