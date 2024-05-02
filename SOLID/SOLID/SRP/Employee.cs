using SOLID.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class Employee
    {

        private readonly EmployeeData _employeeData;
        private readonly SalaryCalculator _salaryCalculator;
        private readonly ReportGenerator _reportGenerator;
        private readonly NotificationService _notificationService;

        public Employee(EmployeeData employeeData, SalaryCalculator salaryCalculator, ReportGenerator reportGenerator, NotificationService notificationService)
        {
            _employeeData = employeeData;
            _salaryCalculator = salaryCalculator;
            _reportGenerator = reportGenerator;
            _notificationService = notificationService;
        }

        public decimal CalculateYearlySalary()
        {
            return _salaryCalculator.CalculateYearlySalary(_employeeData.Salary);
        }

        public void GenerateReport(string reportType)
        {
            _reportGenerator.GenerateReport(_employeeData, reportType);
        }

        public void SendNotification(string recipient, string message)
        {
            _notificationService.SendNotification(recipient, message);
        }


        

    }
}

