using System;

namespace Day_10_Assignment
{
    public interface Itaxtogov
    {
        void paytax(double amt);
    }

    public class myindia : Itaxtogov
    {
        public void paytax(double amt)
        {
            if (amt <= 0)
                throw new Exception("amount must positive");
            else
            {
                double tax = amt * 0.4;
                Console.WriteLine("tax amount which is 40% of {0} : {1}", amt,tax);
            }
        }
    }
    public class myeurope : Itaxtogov
    {
        public void paytax(double amt)
        {
             if (amt <= 0)
                throw new Exception("amount must positive");
            else
            {
                double tax = amt * 0.3;
                Console.WriteLine("tax amount which is 30% of {0} : {1}", amt, tax);
            }
        }
    }

    class Q5
    {
        //Q5. Create a interface Itaxtogov with method void paytax(double amt).
        //    Create a class myindia, myeurope let this class implement this interface.
        //    In class myindia  paytax method will print tax amount which is 40% of the data passed in method.
        //    In class myeurope paytax method will print tax amount which is 30% of the data passed in method.

        public static void calculateTax(Itaxtogov interfaceref, double amt)
        {
            interfaceref.paytax(amt);
        }

        static void Main(string[] args)
        {
            //Itaxtogov ind = new myindia();
            //ind.paytax(100);
            //Itaxtogov europe = new myeurope();
            //europe.paytax(100);

            calculateTax(new myindia(), 1000);
            calculateTax(new myeurope(), 1000);

        }
    }
}