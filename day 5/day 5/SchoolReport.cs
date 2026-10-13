using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    internal  sealed class SchoolReport
    {
        public string ReportTitle { get; set; }



        public void DisplayReportTitle() {
            Console.WriteLine($"ReportTitle :{ReportTitle}");
        }
         public SchoolReport(string title)
        {
            ReportTitle = title;
        }
    }
}
