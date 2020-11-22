using CA.Application.Interfaces;
using CA.Application.ViewModels;
using CA.Domain.Interfaces;
using System;

namespace CA.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public BookViewModel GetBooks()
        {
            return new BookViewModel
            {
                Books = _bookRepository.GetBooks()
            };
        }
    }
}
