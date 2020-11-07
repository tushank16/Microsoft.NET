using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Day_16_Assignment
{
    class MyThread
    {
        public int count; 
        public Thread thrd;

        public MyThread(string name)
        {
            count = 1;
            thrd = new Thread(this.run);
            thrd.Name = name; // set the name of the thread 
            thrd.Start(); // start the thread 
        }

        private void run()
        {
            Console.WriteLine(thrd.Name + " starting.");
            do
            {
                Console.WriteLine("In " + thrd.Name + ", count is " + count);
                Thread.Sleep(500);
                count++;
            } while (count <= 10);
            Console.WriteLine(thrd.Name + " terminating."); 
 
        } 
    }

    class Q2
    {
            //Q2. Write a method which will print 1 to 10. Create 2 thread and let both thread use this method.
            //Use sleep method .
       
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starting.");

            // First, construct a MyThread object. 
            MyThread mt1 = new MyThread("Child #1");
            MyThread mt2 = new MyThread("Child #2");
                        
            Console.WriteLine("Main thread ending.");
        }
    }
}
