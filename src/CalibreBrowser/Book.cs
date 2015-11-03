using SQLite;

namespace CalibreBrowser
{
    [Table("books")]
    public class Book
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }
    }
}