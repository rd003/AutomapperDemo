using AutomapperDemo.Models;
using AutomapperDemo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutomapperDemo.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepo;

        public BooksController(IBookRepository bookRepo)
        {
            _bookRepo = bookRepo;
        }

        [HttpPost]
        public IActionResult AddBook(BookDTO bookDto)
        {
            return CreatedAtAction(nameof(AddBook), bookDto);
        }

    }
}
