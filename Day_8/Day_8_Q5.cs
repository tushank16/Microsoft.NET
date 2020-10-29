using System;

namespace Day_8_Assignment
{
    class Animal 
    {
        public virtual void speak()
        {
            Console.WriteLine("I don’t know how to speak");
        }
    }

    class cat : Animal
    {
       public override void speak()
        {
            Console.WriteLine("mewo mewo");
        }
    }

    class dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("Bhow Bhow");
        }
    }


    class donkey : Animal
    {
 
    }

    class showpoly
    { 
        public void call(Animal refer)
        {
            refer.speak();
        }
    }

    class Day_8_Q5
    {
        public static void Main(String[] args)
        {
            Animal ref1 = new dog();
            Animal ref2 = new cat();
            Animal ref3 = new donkey();

            showpoly show = new showpoly();
            show.call(ref1);
            show.call(ref2);
            show.call(ref3);

        }
    }
}
