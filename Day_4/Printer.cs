using System;

namespace Day_4_Assignment_ClassLibrary_Q4
{
    public class Printer
    {
        private static Printer _instance;
        // Constructor is 'protected'
        private Printer()  
        {
            Console.WriteLine("In Default Constructor");
        }

        public static Printer Instance()
        {       
            if (_instance == null)  
            {   
                _instance = new Printer();
            }
            return _instance;
        }
    }

}

