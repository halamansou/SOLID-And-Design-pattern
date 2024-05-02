using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Full_SOLID
{
    internal interface IOrderProcessor
    {
        void PlaceOrder(string customerName, List<int> productIds, string paymentMethod);
    }
}
