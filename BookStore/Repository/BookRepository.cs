using BookStore.Interface;
using BookStore.Models;

namespace BookStore.Repository
{
    public class BookRepository : IRepository
    {
        public HashSet<Book> Books { get; set; } = new HashSet<Book>
        {
            new Book {Id = 1, Title = "ASP.NET Core for dummy",Publisher = "Apress", Year = 2018, Authors = "Donald Trump"},
            new Book {Id = 2,  Title = "Professional ASP.NET Core 3",Publisher = "Manning", Year = 2019, Authors = "Bill Clinton"},
            new Book {Id = 3,  Title = "ASP.NET Core Self learning",Publisher = "Wiley", Year = 2017,Authors = "Barack Obama"},
            new Book {Id = 4,  Title = "ASP.NET Core quick course",Publisher = "Linda",Authors = "George Bush"},
            new Book {Id = 5,  Title = "ASP.NET Core Video Course",Publisher = "Linda", Authors = "Vladimir Putin"},
        };
        public Book Get(int id) => Books.SingleOrDefault(b => b.Id == id);
        public bool Delete(int id)
        {
            var book = Get(id);
            return book != null ? Books.Remove(book) : false;
        }
        public Book Create()
        {
            var max = Books.Max(b => b.Id);
            var book = new Book() { Id = ++max };
            return book;
        }
        public bool Add(Book book) => Books.Add(book);
        public bool Update(Book book)
        {
            var b = Get(book.Id);
            return b != null ? Books.Remove(b) && Books.Add(book) : false;
        }
    }
}