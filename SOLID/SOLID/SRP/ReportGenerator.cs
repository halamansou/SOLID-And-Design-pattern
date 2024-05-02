using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class ReportGenerator
    {
        public void GenerateReport(EmployeeData employee, string reportType)
        {
            Console.WriteLine($"Generating {reportType} report for {employee.Name}");
        }
    }
}
