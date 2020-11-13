using System;
using System.Collections.Generic;


namespace Day_19_Assignment
{
    class Q3
    {
        static void Main(string[] args)
        {
            //Q3. Display all employee record using disconnected architecture.

            //List<Employee> Emplist = new List<Employee>();
            //Emplist =  EM isplayEmployee.Display();
            //foreach (var e in Emplist)
            //    Console.WriteLine("{0}\t{1}\t{2}", e.Id, e.Name, e.Salary);
            DisplayEmployee Empdisp = new DisplayEmployee();
            Empdisp.Display();
        }
    }
}
