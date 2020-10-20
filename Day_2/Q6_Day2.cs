using System;
using ClassLibrary1;
namespace Day_2_Assignment
{
    class Q6_Day2
    {
        static void Main(string[] args)
        {
            
            //Q6. Accept a number and stored it in byte data type check what happen if you enter 258?
            Console.WriteLine("Enter a Number:");
            string x = Console.ReadLine();
            //byte a;
            //bool b1 = byte.TryParse(x, out a)
            byte a = byte.Parse(x);//System.OverflowExcepion {"Value was either too large or too small for an unsigned byte."}

            //if (b1 == true)
                Console.WriteLine("Byte Data: " + a);
        }
    }
}
