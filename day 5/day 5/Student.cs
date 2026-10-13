using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    internal class Student :Person
    {
        public int Grade { get; set; }
        public string StudentId;

        public void PrintDetails()
        {
            Console.WriteLine(SchoolName);
        }
    }
}
