using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Full_SOLID
{
    internal interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
