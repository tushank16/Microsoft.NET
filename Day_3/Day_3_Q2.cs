using System;
namespace ConsoleApplication1_Assignment_day3
{
    class Day_3_Q1
    {
        struct calculator
        {
            public static void factor(int a)
            {
                int no = a;
                int half = a / 2;
                Console.WriteLine(1);
                for (int i = 2; i <= half; i++)
                {
                    if (no % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine(a);
            }
         }
        //Q2. Accept a number from user and pass it to static method of a struct calculator it should print all factor of a number.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no to find the factors of:");
            string a = Console.ReadLine();
            Console.WriteLine(a);
            int no = Convert.ToInt16(a);
            Console.WriteLine("The factors of " + no + " :");
            calculator.factor(no);
            Console.ReadLine();

        }
    }
}
