using AutomapperDemo.Models;

namespace AutomapperDemo.Repositories
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        List<Book> GetBooks();
    }
    public class BookRepository : IBookRepository
    {

        public void AddBook(Book book)
        {
            // logic will go here
        }

        public List<Book> GetBooks()
        {
            List<Book> dummyBooks = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "Book 1",
                    Author = "Author 1",
                    Year = 2020
                },
                new Book
                {
                    Id = 2,
                    Title = "Book 2",
                    Author = "Author 2",
                    Year = 2019
                },
                new Book
                {
                    Id = 3,
                    Title = "Book 3",
                    Author = "Author 3",
                    Year = 2021
                }
                // Add more dummy book objects as needed
               };

            return dummyBooks;
        }

    }
}
