using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlderUnitTestsConsole
{
    public class ShoppingCart
    {
        public decimal Checkout(List<string> items, PaymentGateway gateway)
        {
            return gateway.GetTotal(items);
        }
    }
}
