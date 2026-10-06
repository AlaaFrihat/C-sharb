using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = "Ahmed";
            int Age = 20;
            int Grade = 12;
            double Average = 85.5;
            char Gender = 'M';
            bool Active = true;
            Console.WriteLine("studentName:" + studentName);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine("Average:" + Average);
            Console.WriteLine("Gender:" + Gender);
            Console.WriteLine("Active:" + Active);

            string[] students = { "Ahmed", "Ali", "Ala`a" };
            Console.WriteLine("students:1 " + students[0]);
            Console.WriteLine("students:2 " + students[1]);
            Console.WriteLine("students:3 " + students[2]);
            Console.WriteLine("Number of students:" + students.Length);
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>//
            Console.WriteLine("students:1 " + students[0]);
            Console.WriteLine("students:3 " + students[2]);
            students[0] = "jana";
            Console.WriteLine("students After:"+ students[0]);




        }
    }
}
