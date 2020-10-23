using System;
using Day_4_Assignment_ClassLibrary_Q3;

namespace Day_4_Assignment
{
    class Question_3
    {
        static void Main(string[] args)
        {
            //      Q3. Create a class customer having member Id, name, billamount.
            //      When you create a object allow to have default vale. Print default value of id,name, billamount. 
            customer customer1 = new customer();
            customer1.display();
            customer customer2 = new customer(1,"Pappa", 12635.0);
            customer2.display();
        }
    }
}
