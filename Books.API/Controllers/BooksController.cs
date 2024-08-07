using Books.Core.Contracts;
using Books.Core.Services;
using Books.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Books.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetAllBooks")]
        public IActionResult GetAllBooks()
        {
            var AllBooks = _bookService.GetAllBooks();
            return Ok(AllBooks);
        }

        [HttpGet("GetBookByID")]
        public IActionResult GetBookByID(int id)
        {
            var AllBooks = _bookService.GetBookById(id);
            return Ok(AllBooks);
        }

        [HttpPost("AddBook")]
        public IActionResult AddBook(int id, string Title, string Author, int Year)
        {
            try
            {
                _bookService.AddBook(new Book(id, Title, Author, Year));
                return Ok();
            }
            catch
            {
                return Problem();
            }
        }
        [HttpPatch("UpdateBook")]
        public IActionResult UpdateBook(int id, string Title, string Author, int Year)
        {
            try
            {
                _bookService.RenewBook(new Book(id, Title, Author, Year));
                return Ok();
            }
            catch
            {
                return Problem();
            }
        }
        [HttpDelete("DeleteBook")]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                _bookService.DeleteBook(_bookService.GetBookById(id));
                return Ok();
            }
            catch
            {
                return Problem();
            }
        }
    }
}
