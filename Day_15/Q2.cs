using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_Assignment
{
    class Q2
    {
        //Q2. Accept 5 element in an array having duplicate value print unique array.

        public static int firstIndex(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == n)
                    return i;

            return -1;
        }
        public static int LastIndex(int[] arr, int n)
        {
            int k=-1;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == n)
                    k = i;
            return k;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[5] { 50, 8, 20, 8, 50 };
            HashSet<int> unique = new HashSet<int>();
            foreach (int k in arr)
                Console.Write(k + " ");
            Console.WriteLine();


            for (int i = 0; i < 5; i++)
            {
                unique.Add(arr[i]);
            }
            Console.WriteLine("\nUnique array:");
            foreach (var d in unique)
            {
                Console.Write(d + " ");
            }
            Console.WriteLine();

        }      
    }
}
