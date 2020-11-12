using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_18_Product_Application
{
    class Q6
    {
        //Q5. Create a table product having column Id, Name ,Qty, price.
        //    Using like query display all product starting from letter ‘t’.
        //    Solve above SQL Injection problem with stored procedure.

        static void Main(string[] args)
        {
            ProductLayer product = new ProductLayer();
            product.displayproductstoredprocedure("t'; Delete from Product;Select * from Product where Name like 't"); //has no effect
            product.displayproductstoredprocedure("t");
        }
    }
}
