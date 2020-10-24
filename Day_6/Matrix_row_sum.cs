using System;

namespace Day_6_Assignment
{
    class Matrix_row_sum
    {
        static void Main(string[] args)
        {
            //Q2. Accept data in 3*3matrix and print row wise sum
            
            int[,] table = new int[3, 3] { {10, 20, 30}, {40, 50, 60}, {70, 80, 90}};
            //printing length
            Console.WriteLine(" Matrix Length : "+table.Length+"\n");

            //Row wise sum
            rowsum(table);
            Console.WriteLine();  

            //Printing the matrix
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(table[i,j] +" ");  
                }
                Console.WriteLine();  
            }          
        }

        static void rowsum(int[,] a)
        {
            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += a[i, j];
                    Console.Write(a[i, j]+" ");
                }
                Console.Write("; Sum :"+ sum);
                Console.WriteLine();  
            }
        }
   }
}
