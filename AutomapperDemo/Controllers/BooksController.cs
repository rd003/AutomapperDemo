using AutoMapper;
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
        private readonly IMapper _mapper;

        public BooksController(IBookRepository bookRepo,IMapper mapper)
        {
            _bookRepo = bookRepo;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddBook(BookDTO bookDto)
        {
            // it is expecting object of Book type as a parameter
            var book = _mapper.Map<Book>(bookDto);
            _bookRepo.AddBook(book);
            return CreatedAtAction(nameof(AddBook), book);
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            IEnumerable<Book> books = _bookRepo.GetBooks();
            //IEnumerable<Book>=> IEnumerable<BookDTO>
            var bookDtoList= _mapper.Map<IEnumerable<BookDTO>>(books);
            return Ok(bookDtoList);
        }

    }
}
