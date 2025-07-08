using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    abstract class Book
    {
        public string ISBN { get; }
        public string Title { get; }
        public int Year { get; }
        public decimal Price { get; }
        protected IBookDeliveryService DeliveryService;

        protected Book(string isbn, string title, int year, decimal price)
        {
            ISBN = isbn;
            Title = title;
            Year = year;
            Price = price;
        }

        public abstract void Buy(int quantity, string email, string address);
    }
}
