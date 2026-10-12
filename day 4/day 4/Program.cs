using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Ala`a", 29, "A");
            stu1.displayinfo();

            Student stu2 = new Student("sara", 27, "B");

            stu2.displayinfo();

            Student stu3 = new Student("Omar",25,"c");
         
            stu3.displayinfo();
        }
    }
}
