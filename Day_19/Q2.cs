using System;

namespace Day_19_Assignment
{
    //      Q2. In the above example 
    //          a. store employee record in database  using store procedure and strongly type insert.
    //          b. Accept id and value for the name to update record.
    //          using ExecutenonQuery() method

    class Q2
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("tushank", 45000);
            InsertData.Insert.insert(e1);

            EmployeeBusinessLayer update = new EmployeeBusinessLayer();
            update.updateNameUsingId(7, "RAAJ");
        }
    }
}
