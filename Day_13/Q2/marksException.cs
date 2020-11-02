using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Assignment
{
    class marksException : Exception
    {
        readonly uint id1;
        readonly string name;
        readonly double marks;
        public string p;

        public marksException(uint id1, string name, double marks, string p)
        {
            // TODO: Complete member initialization
            this.id1 = id1;
            this.name = name;
            this.marks = marks;
            this.p = p;
        }
    }
}
