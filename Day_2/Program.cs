using System;
using Day_2_classlibrary;

namespace Day_2_ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no for squaring");
            string x = Console.ReadLine();
            int a;
            bool b1 = int.TryParse(x, out a);
            if(b1 == true)
                Console.WriteLine("Cube  : " + Class1.cube(a));
                Console.WriteLine("Squre  : " + Class1.square(a));

            Console.Read();
        }
    }
}
