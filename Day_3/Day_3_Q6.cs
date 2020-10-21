using System;


namespace ConsoleApplication1_Assignment_day3
{
    class Day_3_Q6
    {
        public class employee
        {
            public int salary;

            public employee(int sal)
            {
                this.salary = sal;
            }


        }
        static void Main(string[] args)
        {
            //Q6. Create a class having instance member salary. Create a object of a class.
            //Print data type of reference of a class also print parent class name.
            employee e1 = new employee(5000);
            Console.WriteLine(e1.salary);

            Console.WriteLine("Data type of Reference:- {0}\n\nParent Class Name:- {1}", e1.GetType(), e1.GetType().BaseType);
            Console.ReadLine();

        }
    }
}
