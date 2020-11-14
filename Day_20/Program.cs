using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20_Assignnment
{
    class Program
    {
        //Q1. Using disconnected architecture perform insert and update delete.
        static void Main(string[] args)
        {
            EmployeeData_Adapter emp = new EmployeeData_Adapter();
            emp.DisplayEmployee();

            Employee e1 = new Employee("shashank", 40000);
            emp.Insert(e1);
            emp.UpdateNameById(2, "Ojas");
            emp.UpdateSalaryById(2, 40000);
            emp.DeletebyId(7);
            emp.DisplayEmployee();

        }
    }
}
