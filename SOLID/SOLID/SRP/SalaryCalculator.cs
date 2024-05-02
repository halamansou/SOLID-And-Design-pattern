﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class SalaryCalculator
    {
        public decimal CalculateYearlySalary(decimal monthlySalary)
        {
            return monthlySalary * 12;
        }

    }
}
