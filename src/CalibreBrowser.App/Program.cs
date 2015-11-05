using System;
using System.Threading.Tasks;

namespace CalibreBrowser
{
    public class Program
    {
        public static void Main()
        {
            Query().Wait();
        }

        private static async Task Query()
        {
            var bookRepository = new BookRepository(@"..\..\..\..\data\metadata.db");
            var books = await bookRepository.GetBooks();

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}: {book.Title}");
            }
        }
    }
}
