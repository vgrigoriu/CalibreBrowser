using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace CalibreBrowser
{
    public class BookRepository
    {
        private readonly SQLiteAsyncConnection connection;

        public BookRepository(string databasePath)
        {
            connection = new SQLiteAsyncConnection(databasePath);
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await connection.Table<Book>().ToListAsync();
        }
    }
}
