namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            // Adding books
            inventory.AddBook(new PaperBook("PB001", "Clean Code", 2008, 50m, 10));
            inventory.AddBook(new EBook("EB001", "C# in Depth", 2021, 30m, ".pdf"));
            inventory.AddBook(new ShowcaseBook("SC001", "Quantum Physics", 2015, 0m));
            inventory.GetBooks();
            try
            {
                // Buy Paper Book
                Console.WriteLine("\n--- Buying Paper Book ---");
                inventory.BuyBook("PB001", 2, "ziad@gmail.com.com", "123 Cairo St.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            try
            {
                // Buy E-Book
                Console.WriteLine("\n--- Buying E-Book ---");
                inventory.BuyBook("EB001", 1, "ziad@gmail.com", "");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            try
            {
                // Buy Showcase Book
                Console.WriteLine("\n--- Buying Showcase Book (Invalid) ---");
                inventory.BuyBook("SC001", 1, "ziad@gmail.com", "");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\n--- Removing Outdated Books ---");
            inventory.RemoveOutdatedBooks();

            inventory.GetBooks();
        }
    }
}
