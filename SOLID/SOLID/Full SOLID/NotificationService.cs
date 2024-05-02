using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Full_SOLID
{
    internal class NotificationService
    {
        public void SendOrderConfirmationEmail(Order order)
        {
            Console.WriteLine($"Sending order confirmation email to {order.CustomerName}");
        }
    }
}
