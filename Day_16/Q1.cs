using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Assignment
{
    class employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public string address { get; set; }

        public employee(int id, string nm, double sal, string add)
        {
            this.id = id;
            this.name = nm;
            this.salary = sal;
            this.address = add;
        }

        public string display()
        {
            return string.Format(id + "\t" + name + "\t" + salary+  "\t" +address);
        }
    }

    class Q1
    {
        //Q1. Create class  employee having member id, name, salary, address [put address as Vile parle, Andheri, Kandivali].
        //    a. Display all employee detail
        //    b. Display all employee who are staying at Andheri
        //    c. Display total of all salary
        //    d. Display  all employee who’s name start with “v”
        //    e. Count number of Employee in a company
        //    f. Display all employee getting salary > 50000
        //    g. Display min , max and average salary
        //    h. Display all name in ascending order.
        //    i. display all record salary in descending order salary wise
        //    h. display Id and name who’s salary is <20000
        static void Main(string[] args)
        {
            employee e1 = new employee(1, "tushank", 35000.0,"Vile parle");
            employee e2 = new employee(2, "Nihir", 50000.0, "Andheri");
            employee e3 = new employee(3, "ojas", 38000.0, "Kandivali");
            employee e4 = new employee(4, "Shriraj", 55000.0, "Kandivali");
            employee e5 = new employee(5, "Prasana", 36000.0, "Vile parle");
            employee e6 = new employee(6, "Rushi", 40000.0, "Andheri");
            employee e7 = new employee(7, "Virend", 18000.0, "Andheri");

            List<employee> employeeList = new List<employee>();
            employeeList.Add(e1);
            employeeList.Add(e2);
            employeeList.Add(e3);
            employeeList.Add(e4);
            employeeList.Add(e5);
            employeeList.Add(e6);
            employeeList.Add(e7);
            
            //  a. Display all employee detail
            getDetails(employeeList);

            //  b. Display all employee who are staying at Andheri
            employeeStayingAt("Andheri", employeeList);

            //    c. Display total of all salary
            TotalSalary(employeeList);

            //    d. Display  all employee who’s name start with “v”
            namestartswith("V", employeeList);

            //    e. Count number of Employee in a company
            Count(employeeList);

            //    f. Display all employee getting salary > 50000
             salaryGreaterThan(50000, employeeList);

            //    g. Display min , max and average salary
            MaxMinAvgSal(employeeList);

            //    h. Display all name in ascending order.
            displayNameAsc(employeeList);

            //    i. display all record salary in descending order salary wise
            salaryDesc(employeeList);

            //   j. display Id and name who’s salary is <20000
            salaryLessThan(20000, employeeList);
        }

      

        public static void getDetails(List<employee> employeeList)
        {
            Console.WriteLine("a. Display all employee detail");
            IEnumerable<employee> a = from g in employeeList
                                      select g;
            foreach (employee s in a)
                Console.WriteLine(s.display());
            Console.WriteLine("\n");
        }

        public static void employeeStayingAt(string staying, List<employee> employeeList)
        {
            Console.WriteLine("b. Display all employee who are staying at Andheri");
            IEnumerable<employee> b = from g in employeeList
                                      where g.address.Contains(staying)
                                      select g;
            foreach (employee s in b)
                Console.WriteLine("Id: {0}, Name: {1}, Address: {2}", s.id, s.name, s.address);
            Console.WriteLine("\n");
        }

        public static void TotalSalary(List<employee> employeeList)
        {
            double totalSalary = 0;
            Console.WriteLine("c. Display total of all salary");
            IEnumerable<employee> c = from g in employeeList
                                      select g;
            foreach (employee s in c)
            {
                totalSalary += s.salary;
            }
            Console.WriteLine("Total Salary: {0}", totalSalary);
            Console.WriteLine("\n");
        }

        public static void namestartswith(string ch, List<employee> employeeList)
        {
            Console.WriteLine("d. Display  all employee who’s name start with : " + ch);
            IEnumerable<employee> d = from g in employeeList
                                      where g.name.StartsWith(ch)
                                      select g;
            foreach (employee s in d)
                Console.WriteLine("Id: {0}, Name: {1}, Address: {2}", s.id, s.name, s.address);
            Console.WriteLine("\n");
        }

        public static void salaryGreaterThan(double no, List<employee> employeeList)
        {
            Console.WriteLine("f. Display all employee getting salary > " + no);
            IEnumerable<employee> f = from g in employeeList
                                      where g.salary > no
                                      select g;
            foreach (employee s in f)
                Console.WriteLine("Id: {0}, Name: {1}, Address: {2}", s.id, s.name, s.address);
            Console.WriteLine("\n");
        }

        public static void salaryLessThan(double no, List<employee> employeeList)
        {
            Console.WriteLine("j. display Id and name who’s salary is < "+ no);
            IEnumerable<employee> h = from g in employeeList
                                      where g.salary < no
                                      select g;
            foreach (employee s in h)
                Console.WriteLine("Id: {0} : Name: {1}", s.id, s.name);
            Console.WriteLine("\n");
        }

        public static void displayNameAsc(List<employee> employeeList)
        {
            Console.WriteLine("h. Display all name in ascending order.");
            IEnumerable<employee> h = from g in employeeList
                                      orderby g.name ascending
                                      select g;

            foreach (employee s in h)
                Console.WriteLine("Name : {0}", s.name);
            Console.WriteLine("\n");
        }

        public static void MaxMinAvgSal(List<employee> employeeList)
        {
            Console.WriteLine(" g. Display min , max and average salary");
            var max = (from g in employeeList select g.salary).Max();
            var min = (from g in employeeList select g.salary).Min();
            var avg = (from g in employeeList select g.salary).Average();

            Console.WriteLine("Max Salary : {0} ; Min Salary : {1} ; Avaerage Salary : {2} ", max, min, avg);
            Console.WriteLine("\n");
        }

        public static void salaryDesc(List<employee> employeeList)
        {
            Console.WriteLine("i. display all record salary in descending order salary wise");
            IEnumerable<employee> i = from g in employeeList
                                      orderby g.salary descending
                                      select g;

            foreach (employee s in i)
                Console.WriteLine("{0}", s.display());
            Console.WriteLine("\n");
        }

        public static void Count(List<employee> employeeList)
        {
            Console.WriteLine("e. Count number of Employee in a company");
            var count = (from g in employeeList select g).Count();
            Console.WriteLine("Total no. of Employee : "  + count);
            Console.WriteLine("\n");
        }
    }
}
