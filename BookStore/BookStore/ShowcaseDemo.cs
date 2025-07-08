using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class ShowcaseBook : Book
    {
        public ShowcaseBook(string isbn, string title, int year, decimal price)
            : base(isbn, title, year, price) { }

        public override void Buy(int quantity, string email, string address)
        {
            throw new InvalidOperationException("Showcase books are not for sale.");
        }
    }
}
