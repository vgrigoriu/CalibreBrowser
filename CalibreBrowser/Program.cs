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
            var c = new SQLiteAsyncConnection(@"C:\Users\victor\calibre\metadata.db");

            var books = await c.Table<books>().ToListAsync();

            foreach (var book in books)
            {
                Console.WriteLine($"{book.id}: {book.title}");
            }
        }
    }

    public class books
    {
        public int id { get; set; }
        public string title { get; set; }
    }
}
