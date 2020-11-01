using System;

namespace Day_10_Assignment
{
    class Q3
    {
        static void Main(string[] args)
        {
            //Q3. Create C of anonymous object
            //    displaying name and salary. Print all detail
                
            // Make 2 anonymous classes with identical name/value pairs.
            var EmployeeArray = new [] {new { name = "abc", salary = 55000 }, new { name = "xyz", salary = 60000 }};
            Console.WriteLine(EmployeeArray.GetType());// Array [] Anonymous type
            Console.WriteLine();

            foreach (var t in EmployeeArray)
            {
                Console.WriteLine(t.name + "\t" + t.salary);
            }
        }
    }
}