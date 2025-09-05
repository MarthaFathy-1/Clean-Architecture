using LibraryManagementSystem.Domain.Models;

namespace LibraryManagementSystem.Domain.Interfaces
{
    public interface IAuthorRepository
    {
        void AddAuthor(Author author);
        Author? GetById(int id);
        IEnumerable<Author> GetAll();
    }
}
