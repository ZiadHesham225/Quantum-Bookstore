namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookStore store = new BookStore();
            var shipping = new ShippingService();
            var emailDelivery = new MailService();
            // Adding books
            store.AddBook(new PaperBook("PB001", "Clean Code", 2008, 50m, 10, shipping));
            store.AddBook(new EBook("EB001", "C# in Depth", 2021, 30m, ".pdf",emailDelivery));
            store.AddBook(new ShowcaseBook("SC001", "Quantum Physics", 2015, 0m));
            store.GetBooks();
            try
            {
                // Buy Paper Book
                Console.WriteLine("\n--- Buying Paper Book ---");
                store.BuyBook("PB001", 2, "ziad@gmail.com.com", "123 Cairo St.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            try
            {
                // Buy E-Book
                Console.WriteLine("\n--- Buying E-Book ---");
                store.BuyBook("EB001", 1, "ziad@gmail.com", "");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            try
            {
                // Buy Showcase Book
                Console.WriteLine("\n--- Buying Showcase Book (Invalid) ---");
                store.BuyBook("SC001", 1, "ziad@gmail.com", "");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\n--- Removing Outdated Books ---");
            store.RemoveOutdatedBooks();

            store.GetBooks();
        }
    }
}
