using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_Assignment
{
    class Q4
    {
        //Q4 Accept 5 name from user and store it in an array
        //store all name starting from “v” in to another array and print
        //    eg input [vita, vidya, dac, edac,dbda]
        //        O/P [vita, vidya]
        static void Main(string[] args)
        {
            string[] name = new string[5] { "vita", "vidya", "dac", "edac", "dbda" };
            List<string> vname = new List<string>();

            for (int i = 0; i < name.Length; i++)
            {
                if(name[i].StartsWith("v"))
                {
                    vname.Add(name[i]);
                }
            }
            foreach (string x in vname)
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }
} 
