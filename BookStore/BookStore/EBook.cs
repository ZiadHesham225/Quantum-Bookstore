using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class EBook : Book
    {
        public string FileType { get; }

        public EBook(string isbn, string title, int year, decimal price, string fileType)
            : base(isbn, title, year, price)
        {
            FileType = fileType;
            DeliveryService = new MailService();
        }

        public override void Buy(int quantity, string email, string address)
        {
            if (quantity > 1)
                throw new Exception("E-books can't be puchased more than once!!!");

            Console.WriteLine($"E-Book '{Title}' purchased. Amount paid: {Price}");
            DeliveryService.SendBook(Title, email);
        }
    }
}
