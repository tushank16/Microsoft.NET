using System;

namespace Day_4_Assignment_ClassLibrary_Q1
{
    public class Account
    {
        private int id;
        private string Name;
        private float Balanceamt;

        static Account()
        {
            Console.WriteLine("Account Class developed by Tushank Shingte");
        }
            public Account(int id, string Name, float Balanceamt)
            {
                if (Balanceamt < 1000)
                {
                    Console.WriteLine("Min amount required for opeaning account is ₹1000");
                }
                else
                {
                    this.id = id;
                    this.Name = Name;
                    this.Balanceamt = Balanceamt;
                }
            }

            public void deposit(float amount)
            {
                Console.WriteLine("Deposited Amount : " + amount);
                this.Balanceamt = this.Balanceamt + amount;
                Console.WriteLine("Avaliable balance in Account : " + Balanceamt);
            }

            public void withdraw(float amount)
            {
                if (Balanceamt > amount)
                {
                    Console.WriteLine("Withdrawn Amount : " + amount);
                    this.Balanceamt = this.Balanceamt - amount;
                    Console.WriteLine("Avaliable balance in Account : " + Balanceamt);
                }
                else
                {
                    Console.WriteLine("Not Enough balance in Account : " + Balanceamt);
                }
            }
        
    }   
}



