using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class PaperBook : Book
    {
        public int Stock { get; private set; }

        public PaperBook(string isbn, string title, int year, decimal price, int stock)
            : base(isbn, title, year, price)
        {
            Stock = stock;
            DeliveryService = new ShippingService();
        }

        public override void Buy(int quantity, string email, string address)
        {
            if (Stock < quantity)
                throw new Exception("Not enough stock!");

            Stock -= quantity;
            Console.WriteLine($"PaperBook '{Title}' purchased. Amount paid: {Price * quantity}");
            DeliveryService.SendBook(Title, address);
        }
    }
}
