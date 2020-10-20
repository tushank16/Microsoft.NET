using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Assignment
{
    class Q5_Day2
    {
        static void Main(string[] args)
        {
            //Q5. Accept a number from user and print square of it, if in put is not valid give appropriate message
            Console.WriteLine("Enter Number:");
            string x = Console.ReadLine();
            int a;
            bool b1 = int.TryParse(x, out a);
            if (b1 == true)
                Console.WriteLine("Square of Number : " + (a * a));
            else
                Console.WriteLine("Enter Valid Input");

            Console.ReadLine();
        }
    }
}
