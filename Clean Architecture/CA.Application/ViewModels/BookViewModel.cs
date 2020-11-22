using CA.Domain.Models;
using System.Collections.Generic;

namespace CA.Application.ViewModels
{
    public class BookViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
