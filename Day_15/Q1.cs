using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_Assignment
{
    public class subjects
    {
        public int maths { get; set; }
        public int science { get; set; }
        public int english { get; set; }
        public int total { get; set; }
    }
    public class Student
    {
        static int idno;

        int rollno;

        public string name { get; set; }

        public subjects subjects = new subjects();

        public Student(string nm, int math, int sci, int eng)
        {
            if (math >= 0 & sci >= 0 & eng >= 0)
            {
                if (math <= 100 & sci <= 100 & eng <= 100)
                {
                    this.rollno = ++idno;
                    this.name = nm;
                    subjects.maths = math;
                    subjects.science = sci;
                    subjects.english = eng;
                    subjects.total = math + sci + eng;
                }
                else
                {
                    throw new Exception("Marks cannot be more than 100 in any subject");
                }
            }
            else
            {
                throw new Exception("Marks cannot be Negative in any subject");
            }
        }
        public void display()
        {
            Console.WriteLine(rollno + ". \t Name: " + name + "\t MATHS : " + subjects.maths + "\t SCIENCE : " + subjects.science + "\t ENGLISH : " + subjects.english + "\t TOTAL : " + subjects.total + "/300");
        }
        public override string ToString()
        {
            return string.Format(rollno + ". \t Name: " + name + "\t MATHS : " + subjects.maths + "\t SCIENCE : " + subjects.science + "\t ENGLISH : " + subjects.english + "\t TOTAL : " + subjects.total + "/300");
        }
    }
    class Q1
    {
        //          Q1. Create a class Student having member rollno, name, maths, sci, eng,total
        //              Create 5 object and store in sorted list class and display detail name wise ascending order

        static void Main(string[] args)
        {
            try
            {
                Student s1 = new Student("Tushank", 60, 70, 80);
                Student s2 = new Student("Nihir", 90, 80, 80);
                Student s3 = new Student("Rushi", 70, 80, 90);
                Student s4 = new Student("Ojas", 30, 60, 90);
                Student s5 = new Student("Prasanna", 70, 70, 80);
                Student s6 = new Student("Shriraj", 99, 99, 99);
                Console.WriteLine("Before Sorting");

                s1.display();
                s2.display();
                s3.display();
                s4.display();
                s5.display();
                s6.display();
                Console.WriteLine();



                SortedList<int, Student> StudentSortedList = new SortedList<int, Student>();
                StudentSortedList.Add(s1.subjects.total, s1);
                StudentSortedList.Add(s2.subjects.total, s2);
                StudentSortedList.Add(s3.subjects.total, s3);
                StudentSortedList.Add(s4.subjects.total, s4);
                StudentSortedList.Add(s5.subjects.total, s5);
                StudentSortedList.Add(s6.subjects.total, s6);

                Console.WriteLine("After Sorting");

                foreach (KeyValuePair<int, Student> x in StudentSortedList)
                    Console.WriteLine(x.Value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
