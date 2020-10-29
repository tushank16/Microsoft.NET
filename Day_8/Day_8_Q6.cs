using System;

namespace Day_8_Assignment
{
    class mymath
    {
        public static int sum(params int[] b)
        {
            int sum = 0;
            foreach (int a in b)
            {
               sum = sum + a;
            }
            return sum;
        }
    }
    class Day_8_Q6
    {
         //Q6. Create a class mymath having method sum who’s job is to find average.
         //    This method should work even if it’s called with different number of arguments eg. sum(4,5) ,sum(4,7,8,9)

        public static void Main(String[] args)
        {
            Console.WriteLine(mymath.sum(4, 5));
            Console.WriteLine(mymath.sum(4, 7, 8, 9));
            Console.WriteLine(mymath.sum(4, 5 ,6));
            Console.WriteLine(mymath.sum(1, 2, 3, 4, 5));
        }
    }
}
