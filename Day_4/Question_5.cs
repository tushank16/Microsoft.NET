using System;
using Day_4_Assignment_ClassLibrary_Q5;

namespace Day_4_Assignment
{
   
    class Question_5
    {
        static void Main(string[] args)
        {
            //      Q5. Create a class calculator having  static method square, cube, absolute, floor,ceil 
            //      who’s job is to find square, cube, absolute (2.2 ==2)floor(eg. 2.7==O/P==2) , Ceil(eg 2.9==3) value respectively.
            Console.WriteLine(Calculator.square(5));
            Console.WriteLine(Calculator.cube(5));
            Console.WriteLine(Calculator.floor(5.9)); 
            Console.WriteLine(Calculator.absolute(5.9));
            Console.WriteLine(Calculator.Ceil(5.9));
        }
    }
}
