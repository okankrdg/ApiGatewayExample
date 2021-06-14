using Book.Domain.Models;

namespace Book.Domain.Services
{
    public interface IBookService
    {
        BookDTO GetBookByISBN(string isbn);
    }
}
