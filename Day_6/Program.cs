using System;

namespace Day_6_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 10, 20, 30, 40, 50 };
            //Printing Array
            Console.WriteLine("Array values: ");

            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i]+" ");
            Console.WriteLine("\n");

            Console.WriteLine("Length : " + a.Length);
            Console.WriteLine();

            Console.WriteLine("Sum : " + sum(a));
            Console.WriteLine();

            Console.WriteLine("Average : " + average(a));
            Console.WriteLine();

            int[] c = Square(a);//return a new array;
            
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + "^2 = " +c[i]+"\n"); 
            Console.WriteLine("\n");
            
          

            int[] b = Cube(a); //return a new array;

            for (int i = 0; i < b.Length; i++)
                Console.Write(a[i] + "^3 = " + b[i] + "\n");
            Console.WriteLine("\n");

            //cube(a);    //modifies original array;
            

            square(a);    //modifies original array;


            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i]+" ");
            Console.WriteLine("\n");

        }
        static void change(int[] x, int n)
        {
            for (int i = 0; i < x.Length; i++)
                x[i] = x[i] + n;
        }

        static int[] Cube(int[] a)
        {
            int l = a.Length;
            int[] x = new int[l];
            a.CopyTo(x, 0);
            for (int i = 0; i < x.Length; i++)
                 x[i] = x[i] * x[i] * x[i];
            return x;
        }

        static void cube(int[] x)
        {
           for (int i = 0; i < x.Length; i++)
                x[i] = x[i] * x[i] * x[i];
        }

        static void square(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
                x[i] = x[i] * x[i];
        }

        static int[] Square(int[] a)
        {
            int l = a.Length;
            int[] x = new int[l];
            a.CopyTo(x, 0);
            for (int i = 0; i < x.Length; i++)
                x[i] = x[i] * x[i];
            return x;
        }
        static int sum(int[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
                sum += x[i];
            return sum;
        }

        static double average(int[] x)
        {
            double avg = 0;
            for (int i = 0; i < x.Length; i++)
                avg += x[i];
            avg = avg / x.Length;
            return avg;
        }

        static double average(double[] x)
        {
            double avg = 0;
            for (int i = 0; i < x.Length; i++)
                avg += x[i];
            avg = avg / x.Length;
            return avg;
        }
    }
}
