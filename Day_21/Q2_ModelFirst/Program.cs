using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_ModelFirst
{
    class Program
    {
        //Q2.Using model first approach generate database, and classes.
        //    [complete emp dept task] perform insert, delete, update
        static void Main(string[] args)
        {
            Print();

            // Creating Object
            Empdemo emp = new Empdemo { Name = "tshank", Salary = 45000, DeptdemoId = 2 };
            
            //insert object as an entry into the database
            Insert(emp);

            //Updating the values(name and salary) of the employee in database using Id
            UpdateName(10, "Tushank");
            UpdateSalary(10, 48000);

            //Deleting the employee in database using Id
            Delete(7);

            Console.WriteLine("\nAfter Modification:");
            Print();
            
            //Adding new Department
            AddNewDept("FrontEnd");
            PrintDept();
            
            //Updating new Department
            UpdateDept(4, "Backend");
            PrintDept();

            //Delete(6);
            PrintDept();
        }
        public static void Insert(Empdemo obj)
        {
            Model_Emp_DBContainer model_Emp_DB = new Model_Emp_DBContainer();
            model_Emp_DB.Empdemoes.Add(obj);
            model_Emp_DB.SaveChanges();
        }

        public static void UpdateName(int id, string name)
        {
            Model_Emp_DBContainer model_Emp_DB = new Model_Emp_DBContainer();
            var update =model_Emp_DB.Empdemoes.Find(id);
            update.Name = name;
            model_Emp_DB.SaveChanges();
        }
        public static void UpdateSalary(int id, float salary)
        {
            Model_Emp_DBContainer model_Emp_DB = new Model_Emp_DBContainer();
            Empdemo update = model_Emp_DB.Empdemoes.Find(id);
            update.Salary = salary; 
            model_Emp_DB.SaveChanges();
        }

        public static void Delete(int id)
        {
            Model_Emp_DBContainer model_Emp_DB = new Model_Emp_DBContainer();
            Empdemo todelete = model_Emp_DB.Empdemoes.Find(id);
            model_Emp_DB.Empdemoes.Remove(todelete);
            model_Emp_DB.SaveChanges();
        }

        public static void AddNewDept(string deptname)
        {
            Model_Emp_DBContainer db = new Model_Emp_DBContainer();
            Deptdemo dd = new Deptdemo() { Name = deptname };
            db.Deptdemoes.Add(dd);
            db.SaveChanges();
            //Deptdemo dd1 = db.Deptdemoes.Last<Deptdemo>();
            //Console.WriteLine("New dept added\n{0}\t{1}", dd1.Id, dd1.Name);
        }

        public static void UpdateDept(int id, string deptname)
        {
            Model_Emp_DBContainer db = new Model_Emp_DBContainer();
            Deptdemo update = db.Deptdemoes.Find(id);
            update.Name = deptname;
            db.SaveChanges();
        }

        public static void DeleteDept(int id)
        {
            Model_Emp_DBContainer db = new Model_Emp_DBContainer();
            Deptdemo todel = db.Deptdemoes.Find(id);
            db.Deptdemoes.Remove(todel);
            db.SaveChanges();
        }

        public static void PrintDept()
        {
            Model_Emp_DBContainer db = new Model_Emp_DBContainer();
            Console.WriteLine("\nPrinting the list of all the department\n");
            var deptdemolist = db.Deptdemoes.ToList<Deptdemo>();
            foreach (var a in deptdemolist)
                Console.WriteLine("{0}\t{1}", a.Id, a.Name);
        }
        public static void Print()
        {
            Model_Emp_DBContainer model_Emp_DB = new Model_Emp_DBContainer();
            var result = model_Emp_DB.Empdemoes.ToList<Empdemo>();

            //printing the querry
            //Console.WriteLine(model_Emp_DB.Empdemoes);

            //printing the table
            foreach (var e in result)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.Id, e.Name, e.Salary, e.Deptdemo.Name);
        }
    }
}
