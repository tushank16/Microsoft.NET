using System;
using System.IO;

namespace Day_13_Assignment
{
    class student
    {
        public static uint no;
        private uint id;
        private string name;
        private double marks;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public student(string Name, double Marks)
        {
            this.name = Name;
            this.marks = Marks;
            this.id = ++no;
        }
        public override string ToString()
        {
            return string.Format(id+"\t"+name+"\t"+marks);
        }

        public void give_gracemarks(int grace)
        {
            if (grace > 5)
            {
                throw new marksException(id, name, marks, "Grace marks cannot be more tha 5 marks");
            }
            if (grace < 1)
            {
                throw new Exception("Grace marks cannot be Negative");
            }
            marks += grace;

        }
    }
}
    
    

