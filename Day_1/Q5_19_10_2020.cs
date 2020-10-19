using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class demomaths
    {    //public instance method - you can call this method through object of this class
        public static int square(int x)
        { return x * x; }

        public static int cube(int x)
        { return x * x * x; }

    }

    class Q5_19_10_2020
    {
        static void Main(string[] args)
        {
            //Q5. create a class demomaths having method Square , cube which will take float value and return square and cube of a number.
            int variable = 7;
            Console.WriteLine(demomaths.cube(variable));
            Console.WriteLine(demomaths.square(variable));
            Console.Read();
        }
    }
}
