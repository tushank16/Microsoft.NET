using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Assignment
{
    public delegate int intDelegate<T>(T no);

    class Q4
    {
        static int Square(int no)
        {
            return( no * no);
        }
        static int Cube(int no)
        {
            return ( no * no * no);
        }
        static int Factorial(int no)
        {
            int fact = 1;
            for (int i = 2; i <= no; i++)
                fact *= i;
            return(fact);
        }
        //Q4. Write a generic delegate which will point to method which will 
        //return square , cube ,and factorial of a number.

        static void Main(string[] args)
        {
            intDelegate<int> square = new intDelegate<int>(Square);
            intDelegate<int> cube = new intDelegate<int>(Cube);
            intDelegate<int> factorial = new intDelegate<int>(Factorial);

            Console.WriteLine(square(5));
            Console.WriteLine(cube(5));
            Console.WriteLine(factorial(5));
        }
    }
}
