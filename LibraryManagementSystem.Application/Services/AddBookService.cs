using LibraryManagementSystem.Domain.Interfaces;
using LibraryManagementSystem.Domain.Models;

namespace LibraryManagementSystem.Application.Services
{
    public class AddBookService
    {
        private readonly IBookRepository _bookRepository;

        public AddBookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Execute(string title, string author)
        {
            var book = new Book { Title = title, Author = author, IsBorrowed = false };
            _bookRepository.AddBook(book);
        }
    }
}
