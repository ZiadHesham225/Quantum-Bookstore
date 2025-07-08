using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class BookStore
    {
        private Dictionary<string, Book> books;
        private int outdatedYears = 5;
        public BookStore()
        {
            books = new Dictionary<string, Book>();
        }

        public void AddBook(Book book)
        {
            if (books.ContainsKey(book.ISBN))
            {
                Console.WriteLine($"Book with ISBN {book.ISBN} already exists!!!");
                return;
            }
            books[book.ISBN] = book;
        }
        public void RemoveOutdatedBooks()
        {
            int currentYear = DateTime.Now.Year;
            List<Book> booksToRemove = new List<Book>();

            foreach (var pair in books)
            {
                Book book = pair.Value;
                int bookAge = currentYear - book.Year;
                if (bookAge > outdatedYears)
                {
                    booksToRemove.Add(book);
                }
            }

            foreach (var book in booksToRemove)
            {
                books.Remove(book.ISBN);
                Console.WriteLine($"Book: {book.Title} with {book.ISBN}: isbn is removed!!!");
            }
        }
        public void BuyBook(string isbn, int quantity, string email, string address)
        {
            if (!books.ContainsKey(isbn))
                throw new Exception("Book not found!!!");

            Book book = books[isbn];
            book.Buy(quantity, email, address);
        }
        public void GetBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available in the store!!!");
                return;
            }
            Console.WriteLine("Available books:");
            foreach (var book in books.Values)
            {
                Console.WriteLine($"ISBN: {book.ISBN}, Title: {book.Title}, Year: {book.Year}, Price: {book.Price:C}");
            }
        }
    }
}
