using AutomapperDemo.Models;

namespace AutomapperDemo.Repositories
{
    public interface IBookRepository
    {
        void AddBook(BookDTO book);
    }
    public class BookRepository : IBookRepository
    {

        public void AddBook(BookDTO book)
        {
            // logic will go here
        }
    }
}
