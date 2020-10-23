using System;
using Day_4_Assignment_ClassLibrary_Q1;

namespace Day_4_Assignment
{
    class Question_1
    {
        static void Main(string[] args)
        {
        //Q1.   Create a class Account having private instance member Id, Name Balanceamt. 
        //      Create method deposit who’s job is to increase Balanceamtby the amout deposited buy account holder. 
        //      Create method withdraw who’s job is to decrease Balanceamtby the amout  withdrwan buy account holder. 
        //      Write method display which will display name and Balanceamt. This application will be classlibrary.
        //      Create console application and use this class library. 
        //      Create at least two object of account class and deposit and withdraw money.
            Account Ref1 = new Account(1, "Tushank", 1000);
            Ref1.withdraw(2000);
            Account Ref2 = new Account(1, "Ojas", 10000);
            Ref2.withdraw(2000);
            Account Ref3 = new Account(1, "Nihir", 10000);
            Ref3.deposit(2000);
        }
    }
}
