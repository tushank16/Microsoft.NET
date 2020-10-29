using System;

namespace Day_8_Assignment
{
    class Mymeth
    {
        public static int sqr(int n)
        {
            return n * n;
        }
        public static double sqr(double s)
        {
            return s * s;
        }
    }

    class Day_8_Q1
    {
        //Q1.   Create a static class Mymeth having two static  method
        //      1. public int sqr(int n) :this method return square of a number
        //      2. public double sqr(double s): this method return square of a number
        //      Create a entry point class and call this method.

        static void Main(string[] args)
        {
            Console.WriteLine(Mymeth.sqr(10.2));
            Console.WriteLine(Mymeth.sqr(5));

        }
    }

    
}
