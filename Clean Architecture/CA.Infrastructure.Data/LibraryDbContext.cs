using CA.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CA.Infrastructure.Data
{
    public class LibraryDbContext: DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
