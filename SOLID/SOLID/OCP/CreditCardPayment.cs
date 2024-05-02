﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    internal class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            
            Console.WriteLine($"Processing credit card payment of ${amount}");
        }
    }
}
