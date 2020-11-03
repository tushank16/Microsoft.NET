using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Assignment
{
    class employee
    {
        public static int idno;
        private readonly int id;

        public int Id
        {
            get { return id; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double salary;

        public employee(string nm, double sal)
        {
            // TODO: Complete member initialization
            this.id = ++idno;
            this.Name = nm;
            this.Salary = sal;
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public override string ToString()
        {
            return string.Format(id + "\t" + name + "\t" + salary);
        }
    }

    static class swap
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap() method a {0}", typeof(T));
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        public static void DisplayBaseClass<T>()
        {
            Console.WriteLine("Base class of {0} is: {1}.", typeof(T), typeof(T).BaseType);
        }

    }
    class Q2
    {
        //Q2. Write a static class with generic method swap,
        //    which should able to swap 2 value of any type
        //    and it should also swap two employee object. 

        static void Main(string[] args)
        {
            employee e1 = new employee("tushank", 100000.0);
            employee e2 = new employee("Sahil", 60000.0);
            Console.WriteLine("Before swap: ");
            Console.WriteLine(e1.ToString());
            Console.WriteLine(e2.ToString());
            Console.WriteLine();

            swap.Swap<employee>(ref e1, ref e2);
            Console.WriteLine("After swap: ");
            Console.WriteLine(e1.ToString());
            Console.WriteLine(e2.ToString());
        }
    }
}
