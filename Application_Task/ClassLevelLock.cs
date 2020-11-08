using System;
using System.Threading;

namespace ConsoleApplication1_lecture
{
    class math
    {
        int fact;
        object lockOn = new object(); // a private object to lock on
        public int factorial(int no)
        {
            lock (lockOn)
            { // lock the entire method
                this.fact = 1; // reset fact
                for (int i = 2; i <= no; i++)
                {
                    fact *= i;
                    Console.WriteLine("Running totalfor" + Thread.CurrentThread.Name + "is" + fact);
                    Thread.Sleep(100); // allow task-switch
                }
                return fact;
            }
        }
    }

    class MyThread
    {
        public Thread Thrd;
        int a;
        int answer;
        // Create one SumArray object for all instances of MyThread.
        static math sa = new math();
        // Construct a new thread.
        public MyThread(string name, int nums)
        {
            this.a = nums;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start(); // start the thread
        }
        // Begin execution of new thread.
        void Run()
        {
            Console.WriteLine(Thrd.Name + " starting.");
            answer = sa.factorial(a);
            Console.WriteLine("factorial for " + Thrd.Name + " is " + answer);
            Console.WriteLine(Thrd.Name + " terminating.");
        }
    }


    class ClassLevelLock
    {
        static void Main(string[] args)
        {
            MyThread mt1 = new MyThread("Child #1", 1);
            MyThread mt2 = new MyThread("Child #2", 1);
            mt1.Thrd.Join();
            mt2.Thrd.Join();   
        }
    }
}
