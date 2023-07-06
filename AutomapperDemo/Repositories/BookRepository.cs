﻿using AutomapperDemo.Models;

namespace AutomapperDemo.Repositories
{
    public interface IBookRepository
    {
        void AddBook(BookDTO book);
        //List<BookDTO> GetDummyBooks();
    }
    public class BookRepository : IBookRepository
    {

        public void AddBook(BookDTO book)
        {
            // logic will go here
        }

        //public List<BookDTO> GetDummyBooks()
        //{
        //    List<BookDTO> dummyBooks = new List<BookDTO>
        //    {
        //        new BookDTO
        //        {
        //            BookId = 1,
        //            Title = "Book 1",
        //            Author = "Author 1",
        //            Year = 2020
        //        },
        //        new BookDTO
        //        {
        //            BookId = 2,
        //            Title = "Book 2",
        //            Author = "Author 2",
        //            Year = 2019
        //        },
        //        new BookDTO
        //        {
        //            BookId = 3,
        //            Title = "Book 3",
        //            Author = "Author 3",
        //            Year = 2021
        //        }
        //        // Add more dummy book objects as needed
        //       };

        //    return dummyBooks;
        //}

    }
}
