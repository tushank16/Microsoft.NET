using System;

namespace Day_4_Assignment_ClassLibrary_Q5
{
    public class Calculator
    {
        public static int square(int a)
        {
            return a * a;
        }
        public static int cube(int a)
        {
            return a * a * a;
        }
        public static int absolute(double a)
        {
            int no = (int)a;
            return no;
        }
        public static int floor(double b)
        {
            int no = (int)b;
            return no;
        }
        public static int Ceil(double c)
        {
            int no = (int)c;
            return no+1;
        }
    }
}
