using System;

namespace ConsoleApplication1_Assignment_day3
{
    class Day_3_Q1
    {
        struct Math
        { 
            public static int square(int a)
            {
                return a * a;
            }
            public static int cube(int a)
            {
                return a * a * a;
            }
        }
        //Q1. Create a struct Math having two static method square and cube. Using struct variable call this method and print square and cube of a number
        static void Main(string[] args)
        {
            Console.WriteLine(Math.square(5));
            Console.WriteLine(Math.cube(6));
            Console.ReadLine();

        }
    }
}
