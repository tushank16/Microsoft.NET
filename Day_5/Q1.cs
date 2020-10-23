using System;
using Day_5_Assignment_ClassLibrary_Q1;

namespace Day_5_Assignment
{
    
    class Q1
    {
        static void Main(string[] args)
        {
            //Q1. Create a class Employee having member variable Firstname, Lastname, Middlename.
            //    let your application create object even if user does not enter Middlename.
            //    Create two constructor one take parameter for Firstname, Lastname and second constructor which will take all the parameter.
            //   Write display method which will display detail of the object.
           Employee emp1 = new Employee("Tukaram", "Shingte");
           emp1.display();
           Employee emp2 = new Employee("Tushank", "Shingte","Tukaram");
           emp2.display();

        }
    }
}
