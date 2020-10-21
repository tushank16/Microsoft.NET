using System;
using mycaculator;

namespace ConsoleApplication1_Assignment_day3
{
    class Day_3_Q4
    {
        //Q4. Create class library “mycaculator” having instance method  add and product which will return sum and product of two number. 
        //Create shared assembly and use in your project.
        //After  this add method cube  to a copy of class library “mycaculator” change the version and add it to GAC.
        //Create a application to use this new version of library. Ensure that your both console application works.        
        public static void Main(string[] args)
        {        
            Console.WriteLine( mycaculator.mycaculator.add(10,20));
            Console.WriteLine(mycaculator.mycaculator.product(10, 20));

            Console.ReadLine();

        }
    }
}
