using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_Assignment
{
    delegate int[] evenarray(int[] arr);

    class Q3
    {
        //Q3. Accept 5 element in an array and store all even number in another array and print. Use lambda 



        static void Main(string[] args)
        {
            int[] arr = new int[5] { 50, 1, 20, 16, 17 };
            evenarray evenarray = arr1 =>
            {
                int i, j;
                int[] arr2 = new int[arr1.Length];
                for (i = 0, j = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] % 2 == 0)
                    {
                        arr2[j] = arr1[i];
                        j++;
                    }
                }

                return arr2;
            };
            int[] arr3 = evenarray(arr);
            for (int i = 0; i < arr3.Length; i++)
            {
                if (arr3[i] != 0)
                    Console.Write(arr3[i] + " ");
            }
        }
    }
}
