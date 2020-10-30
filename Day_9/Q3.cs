using System;

namespace Day_9_Assignment
{
    class Q3
    {
        //Q3. Accept a number from user and store in object and print it

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            String no = Console.ReadLine();
            int n = Convert.ToInt32(no);
            object o = n;

            Console.WriteLine("The Entered Number is " + o);

        }
    }
}