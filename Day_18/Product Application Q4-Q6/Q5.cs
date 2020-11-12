using System;

namespace Day_18_Product_Application
{
    class Q5
    {
        //Q5. Create a table product having column Id, Name ,Qty, price.
        //    Using like query display all product starting from letter ‘t’.
        //    above SQL Injection problem with parameterised query.

        static void Main(string[] args)
        {
            ProductLayer product = new ProductLayer();
            product.displayproductParameterisedQuerry("t'; Delete from Product;Select * from Product where Name like 't"); //has no effect


        }
    }
}