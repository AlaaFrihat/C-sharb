using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected string SchoolName;

        private string _internalCode; //  private لانها 

        public void Displayinfo()
        {
            Console.WriteLine($"Name :{Name}, Age :{Age}");
        }
    }
}
