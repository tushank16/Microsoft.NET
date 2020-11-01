using System;

namespace Day_10_Assignment
{
    class Address
    {
        public string location { get; set; }
        public Address()
        {
            location = "";
        }
    }

    class employee : ICloneable
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Address address = new Address();

        public employee(string nm, int sal, string add)
        {
	        Name = nm;
	        Salary = sal;
            address.location = add;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Name, Salary, address.location);
        }


        public object Clone()
        {
            employee NewEmployee = (employee)this.MemberwiseClone();
            Address currentAddress = new Address();
            currentAddress.location = this.address.location;
            NewEmployee.address = currentAddress;
            return NewEmployee;
        }
    }

    class Q4
    {
        //Q4. Create a class employee having member name and salary.
        //    It has reference of address class which display location name[eg. vile-parle].
        //    Create a duplicate object using clone method.

        static void Main(string[] args)
        {
            employee e1 = new employee("tushank", 40000, "dadar");
            employee e2 = (employee)e1.Clone();//cloning 


            Console.WriteLine("Before modification:");
            Console.WriteLine("Employee 1: {0}", e1);
            Console.WriteLine("Employee 2: {0}", e2);
            Console.WriteLine();

            //changing the data of the cloned object
            e2.Name = "Shashank";
            e2.Salary = 45000;
            e2.address.location = "parel";
            Console.WriteLine();

            Console.WriteLine("After modification:");
            Console.WriteLine("Employee 1: {0}", e1);
            Console.WriteLine("Employee 2: {0}", e2);


        }
    }
}