using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    internal class Teacher:Person
    {
        public string Subject { get; set; }

        public Teacher() : base() {}

        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"Name :{Name}, Age :{Age},{Subject}");
        }
    }
}
