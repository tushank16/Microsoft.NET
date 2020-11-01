using System;

namespace Day_11_Assignment
{
    static class math
    {
        //Square
        public static int square(int n)
        {
            return n * n;
        }

        //Cube
        public static int cube(int n)
        {
            return n * n * n;
        }

        //factorial 
        public static int factorial(int n)
        {
            int fact =1;
            for (int i = 1; i < n; i++)
                fact *= n;
            return fact;
        }
    
    }

    delegate int mymath(int n);

    class Q1
    {
        static void Main(string[] args)
        {
            mymath ref1 = new mymath(math.square);
            Console.WriteLine(ref1(5));

            mymath ref2 = new mymath(math.cube);
            Console.WriteLine(ref2(5));

            mymath ref3 = new mymath(math.factorial);
            Console.WriteLine(ref3(2));

        }
    }
}
