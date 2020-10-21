using System;

namespace ConsoleApplication1_Assignment_day3
{
    class Day_3_Q5
    {
        static void Main(string[] args)
        {
            //Q5. Accept a number from user and display its type and parent class 
            Console.WriteLine("Enter a no to display its type and parent class:");
            string a = Console.ReadLine();
            Console.WriteLine(a);
            int no = Convert.ToInt16(a);
            Console.WriteLine("Type of {0} is: {1}", no, no.GetType());
            Console.WriteLine("Parent Class of {0} is: {1}", no, no.GetType().BaseType);
            Console.ReadLine();

        }
    }
}
