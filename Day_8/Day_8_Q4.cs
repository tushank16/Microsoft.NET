using System;

namespace Day_8_Assignment
{
    class swapdemo
    {
        public static void swap(int x, int y)
        {
            Console.WriteLine("in swap Before Swap {0} & {1}", x, y);
            x += y -= x;
            Console.WriteLine("in swap After Swap {0} & {1}", x, y);
        }
    }

    class Day_8_Q4
    {
       
       static void Main(string[] args)
       {
                //Q4. Create a class swapdemo having method
                //    Public void swap(int x, int y)
                //    Job of this method is to swap two number.
                //    Create a entry point class  who’s job is to call this method and print swapped data.

                int a = 10, b = 20;
                swapdemo.swap(a, b);
        }
    }
}
