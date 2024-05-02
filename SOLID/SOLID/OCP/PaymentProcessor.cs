using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    internal class PaymentProcessor
    {
        public void ProcessPayment(IPaymentMethod paymentMethod, double amount)
        {
            paymentMethod.ProcessPayment(amount);
        }
    }
}
