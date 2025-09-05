using LibraryManagementSystem.Domain.Models;

namespace LibraryManagementSystem.Domain.Interfaces
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        Book? GetById(int id);
        IEnumerable<Book> GetAll();
    }
}
