﻿using System;
using Day_5_Assignment_ClassLibrary_Q2;

namespace Day_5_Assignment
{


    class Q2
    {
        static void Main(string[] args)
        {
            //  Q2. Create a class Account having private instance member Id, Name Balanceamt.
            //  Id should be generated by application. Create method deposit who’s job is to increase Balanceamtby the amout deposited by account holder.
            //  Create method withdraw who’s job is to decrease Balanceamt by the amount  withdrawn by account holder. 
            //  Write method display which will display name and Balanceamt.
            //  Your application should generate only 3 object, if you try to generate 4 th object it should display message can not create object. This application will be classlibrary.
            //  Create console application and use this class library. Create at least two object of account class and deposit and withdraw money.

            Account Ref1 = new Account("tushank", 1000.0);
            Ref1.display();

            Account Ref2 = new Account("Shashank", 1000.0);
            Ref2.display();
        }
    }
}