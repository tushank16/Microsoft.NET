using System;

namespace Day_4_Assignment_ClassLibrary_Q3
{
    public class customer
    {
        private int id;
        private string name;
        private double billamount;
        static customer()
        {
            Console.WriteLine("\n Customer Class developed by Tushank Shingte");
        }
        public customer()
        {
            this.id = 0;
            this.name = "Default";
            this.billamount = 0.0;
        }
        public customer(int id, string name, double bill)
        {
            this.id = id;
            this.name = name;
            this.billamount = bill;
        }
        public void display()
        {
            Console.WriteLine("id : {0}; Name : {1}; BillAmount : {2}", id, name, billamount);
        }

    }
}
