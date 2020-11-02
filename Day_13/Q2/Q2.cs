using System;
using System.IO;

namespace Day_13_Assignment
{
    class Q2
    {
        //Q2. Create a class student having member id, name,  marks.
        //    Write method public void give_gracemarks(int mks) when you call method with marks>5 it should throw  user define exception.
        //    It should print name id and marks to file, using file handling topic

        static void Main(string[] args)
        {
            student s1 = new student("tushank", 50);
            student s2 = new student("raj", 45);

            Console.WriteLine("\nMarks Before giving grace:");
            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());
            try 
            {
                s1.give_gracemarks(10);
            }
            catch (marksException e)
            {
                Console.WriteLine("\nmarksException :" + e.p);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nException : "+e.Message);
            }
            try
            {
                s2.give_gracemarks(-2);
            }
            catch (marksException e)
            {
                Console.WriteLine("\nmarksException :" + e.p);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nException : " + e.Message);
            }

            Console.WriteLine("\nMarks After giving grace:");

            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());

            Console.WriteLine("Adding data into the file:\n");

            FileStream fWrite;
            string s = s1.ToString();
            s += "\n";
            s += s2.ToString();
            //Console.WriteLine(s);      

            fWrite = new FileStream("Student.txt", FileMode.Create, FileAccess.Write);
            StreamWriter stwr = new StreamWriter(fWrite, System.Text.Encoding.UTF8);
            stwr.Write(s);
            stwr.Close();

            Console.WriteLine("Retriving data into the file:\n");

            FileStream fRead = new FileStream("Student.txt", FileMode.Open, FileAccess.Read);

            StreamReader fstr_in = new StreamReader(fRead);
            while ((s = fstr_in.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            fstr_in.Close();
                 
        }
    }
}
