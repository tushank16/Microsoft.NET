using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Assignment
{
    class Q1_Day2
    {
        static void Main(string[] args)
        {
            //Q1. Accept two number from user and print sum of it.
            Console.WriteLine("Enter 2 Numbers:");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            int a, b;
            bool b1 = int.TryParse(x, out a);
            bool b2 = int.TryParse(y, out b);
            if(b1 = b2 == true)
                Console.WriteLine("Sum of 2 Numbers : " + (a+b));
            Console.ReadLine();
        }
    }
}
