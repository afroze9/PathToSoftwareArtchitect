using CA.Domain.Models;
using System.Collections.Generic;

namespace CA.Domain.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
    }
}
