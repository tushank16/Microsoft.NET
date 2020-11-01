using System;

namespace Day_11_Assignment
{
    //deligate accepting 1 int parameter and returning int
    delegate int mymath(int n);


    //non static class math with instance method
    class math
    {
        //Square
        public int square(int n)
        {
            return n * n;
        }

        //Cube
        public int cube(int n)
        {
            return n * n * n;
        }

        //factorial 
        public int factorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
                fact *= i;
            return fact;
        }

    }
      
    class Q2
    {
        static void Main(string[] args)
        {
            math obj = new math();
            mymath ref1;

            ref1 = new mymath(obj.square);
            Console.WriteLine(ref1(5));

            ref1 = new mymath(obj.cube);
            Console.WriteLine(ref1(5));

            ref1 = new mymath(obj.factorial);
            Console.WriteLine(ref1(5));

        }
    }
}
