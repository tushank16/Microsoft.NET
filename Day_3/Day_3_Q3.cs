using System;

namespace ConsoleApplication1_Assignment_day3
{
    class Day_3_Q3
    {
        struct emp
        {
            public string name;
            public int salary;
            public emp(string name, int salary)
            {
                this.name = name;
                this.salary = salary;
            }
            public void display()
            {
                 Console.WriteLine("Name : {0}; Salary : {1}" ,name, salary);
            }

        }
        //Q3. Create struct emp having member name and salary, using constructor initialized member. Write display method which will display name and salary
        static void Main(string[] args)
        {
            emp emp1 = new emp("ABC", 10000);

            emp1.display();
            Console.ReadLine();

        }
    }
}
