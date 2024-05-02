using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Full_SOLID
{
    internal class Order
    {
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalCost { get; set; }
    }
}
