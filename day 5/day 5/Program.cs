using day_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
  
    }
internal class Program
{
    static void Main(string[] args)
    {

        Person p1 = new Person();
        // p1.SchoolName;لا نستطيع الوصول اليها لانه محمي 
        //p1._internalCode; لا نستطيع الوصول اليهم خارج الكلاس تبعهم لانها برافيت 

        SchoolReport r1 = new SchoolReport("Ala`a");

        r1.DisplayReportTitle();

        Student s1 = new Student();
        s1.Age = 18;
        s1.Name = "ali";
        Student s2 = new Student();
        s2.Age = 19;
        s2.Name = "Ahmed";

        Teacher t1 = new Teacher();
        t1.Name = "Saif";

        s1.Displayinfo();

        





    }
}

