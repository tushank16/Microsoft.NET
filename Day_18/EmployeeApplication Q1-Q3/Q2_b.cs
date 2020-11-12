/*using System;

namespace Day_18_Assignment
{
    class Q2_b
    {
        //Q2. b. UPDATE employee record in database using ExecutenonQuery() method 

        static void Main(string[] args)
        {
            EmployeeLayer employee = new EmployeeLayer();
            var list = employee.ListEmployees;
            foreach (var a in list)
            {
                Console.WriteLine("{0}\t{1}\t{2}", a.Id, a.Name, a.Salary);
            }
            UpdateEmployee updateemployee = new UpdateEmployee();
            updateemployee.Update_EmployeeNameByID(1, "Tushank");

            updateemployee.Update_EmployeeSalaryByID(2, 40000);

            list = employee.ListEmployees;
            foreach (var a in list)
            {
                Console.WriteLine("{0}\t{1}\t{2}", a.Id, a.Name, a.Salary);
            }
        }
    }
}
*/