using BookStore.Models;

namespace BookStore.Interface
{
    public interface IRepository
    {
        public HashSet<Book> Books { get; set; }
        public Book Get(int Id);
        public bool Delete(int Id);
        public Book Create();
        public bool Add(Book book);
        public bool Update(Book book);

    }
}
