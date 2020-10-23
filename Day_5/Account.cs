using System;

namespace Day_5_Assignment_ClassLibrary_Q2
{
    public class Account
    {
        private static int AccId = 1; // given by bank
        private int Id;
        private string Name;
        private double Balanceamt;
        static Account()
        {
            Console.WriteLine("\nAccount Class developed by Tushank Shingte\n");
        }
        public Account(string Name, double Balanceamt)
        {
            if (Balanceamt < 1000)
            {
                Console.WriteLine("Min amount required for opeaning account is ₹1000");
            }
            else
            {
                this.Id = AccId;
                AccId++;
                this.Name = Name;
                this.Balanceamt = Balanceamt;
            }
        }

        public void display()
        {
            Console.WriteLine(GetType());
            Console.WriteLine(" Id = {0}; Name = {1}; Balanceamt = {2}\n", Id, Name, Balanceamt);
        }
        public void deposit(double amount)
        {
            Console.WriteLine("Deposited Amount : " + amount);
            this.Balanceamt = this.Balanceamt + amount;
            Console.WriteLine("New Avaliable balance in Account : " + Balanceamt);
        }

        public void withdraw(double amount)
        {
            if (Balanceamt > amount)
            {
                Console.WriteLine("Withdrawn Amount : " + amount);
                this.Balanceamt = this.Balanceamt - amount;
                Console.WriteLine("New Avaliable balance in Account : " + Balanceamt);
            }
            else
            {
                Console.WriteLine("Not Enough balance in Account : " + Balanceamt);
            }
        }
    }
}
