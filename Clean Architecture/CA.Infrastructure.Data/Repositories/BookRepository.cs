using CA.Domain.Interfaces;
using CA.Domain.Models;
using System.Collections.Generic;

namespace CA.Infrastructure.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _context;

        public BookRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books;
        }
    }
}
