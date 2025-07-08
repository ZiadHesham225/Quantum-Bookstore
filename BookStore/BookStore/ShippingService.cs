using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class ShippingService : IBookDeliveryService
    {
        public void SendBook(string title, string destination)
        {
            Console.WriteLine($"Shipping '{title}' to address: {destination}");
        }
    }
}
