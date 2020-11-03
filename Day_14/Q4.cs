using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Assignment
{
    public delegate void intDelegate<T>(T no);

    class Q4
    {
        static void Square(int no)
        {
            Console.WriteLine("Square of {0} is: {1}", no, no*no);
        }
        static void Cube(int no)
        {
            Console.WriteLine("Cube of {0} is: {1}", no, no * no * no);
        }
        static void Factorial(int no)
        {
            int fact = 1;
            for (int i = 2; i <= no; i++)
                fact *= i;
            Console.WriteLine("Factorial of {0} is: {1}", no, fact);
        }
        //Q4. Write a generic delegate which will point to method which will 
        //return square , cube ,and factorial of a number.

        static void Main(string[] args)
        {
            intDelegate<int> square = new intDelegate<int>(Square);
            intDelegate<int> cube = new intDelegate<int>(Cube);
            intDelegate<int> factorial = new intDelegate<int>(Factorial);

            square(5);
            cube(5);
            factorial(5);
        }
    }
}
