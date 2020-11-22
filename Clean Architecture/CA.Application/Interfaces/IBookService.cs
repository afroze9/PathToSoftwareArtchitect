using CA.Application.ViewModels;

namespace CA.Application.Interfaces
{
    public interface IBookService
    {
        BookViewModel GetBooks();
    }
}
