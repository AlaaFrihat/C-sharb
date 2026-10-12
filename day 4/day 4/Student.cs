using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    internal class Student
    {
        public string name;
        public int age;
        public string grade;
        public Student(string studentname, int studentage, string studentgrade)
        {
            name = studentname;
            age = studentage ;
            grade = studentgrade ;
        }

        public void displayinfo()
        {
            Console.WriteLine(" name:"+ name);
            Console.WriteLine("age:" + age);
            Console.WriteLine("grade:" + grade);
        }
    }
}
