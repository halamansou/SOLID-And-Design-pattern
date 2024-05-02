using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class NotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending  notification to {recipient}: {message}");
        }

    }
}
