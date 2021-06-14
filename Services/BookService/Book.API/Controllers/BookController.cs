using Book.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Book.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService BookService;
        public BookController(IBookService bookService)
        {
            BookService = bookService;
        }
        public ActionResult Get(string isbn)
        {
            var book = BookService.GetBookByISBN(isbn);
            return Ok(book);
        }
    }
}
