using LibraryManagementSystem.Domain.Interfaces;
using LibraryManagementSystem.Domain.Models;
using LibraryManagementSystem.Infrastructure.Data;

namespace LibraryManagementSystem.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _context;

        public BookRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public void AddBook(Book book) => _context.Books.Add(book);
        public Book? GetById(int id) => _context.Books.Find(id);
        public IEnumerable<Book> GetAll() => _context.Books.ToList();
    }

}
