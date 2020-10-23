using System;
using Day_4_Assignment_ClassLibrary_Q4;

namespace Day_4_Assignment
{
    class Question_4
    {
        static void Main(string[] args)
        {
            //      Q4. Create a class Printer with a private constructor. 
            //      Your application should give only one reference of the printer object. 
            Printer p1 = Printer.Instance();

            Printer p2 = Printer.Instance();
            // Test for same instance

            if (p1 == p2)
            {

                Console.WriteLine("Objects are the same instance");
            }

        }
    }
}
