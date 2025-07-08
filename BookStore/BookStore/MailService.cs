using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class MailService : IBookDeliveryService
    {
        public void SendBook(string title, string destination)
        {
            Console.WriteLine($"Sending '{title}' as eBook to email: {destination}");
        }
    }
}
