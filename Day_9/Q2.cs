using System;

namespace Day_9_Assignment
{
    class person
    { 
        public virtual string  dojob()
        { 
           return "doing job";
        }  
    }

    class programmer : person
    {
        public override string dojob()
        {
            return "doing coding";
        }
        public void testing()
        {
           Console.WriteLine("I am testing code also");
        }
    }


    class dancer : person
    {
        public override string dojob()
        {
            return base.dojob();
        }
    }

    class singer : person
    {
        public override string dojob()
        {
            return "singing";
        }
    }


    class Q2
    {
        //Q2. Create a class person having virtual method
        //    public virtual string  dojob(){ “doing job”}
        //    create three child class programmer,dancer and singer.
        //    In programmer class override virtual method
        //    public override string  dojob(){ “doing coding”}
        //    programmer class also has method public void testing{  “I am testing code also” }
        //    In  singer class override virtual method
        //    public override string  dojob(){ “singing”}
        //    in dancer class no method available.
        //    Create array of person class and call dojob() method.
        //    Also call testing method of programmer class in a loop

        static void Main(string[] args)
        {
            person [] arr = new person[3];
            arr[0] = new programmer();
            arr[1] = new dancer();
            arr[2] = new singer();
            for (int i = 0; i < 3; i++)
            {
                    Console.WriteLine(arr[i].dojob());
                    if (arr[i] is programmer)
                        ((programmer)arr[i]).testing();
            }           
        }
    }
}