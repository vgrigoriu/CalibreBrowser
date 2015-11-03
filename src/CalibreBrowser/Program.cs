using SQLite;
using System;
using System.Threading.Tasks;

namespace CalibreBrowser
{
    class Program
    {
        static void Main(string[] args)
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

    [Table("books")]
    public class Book
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }
    }
}
