using LibraryManagementSystem.Domain.Models;
using LibraryManagementSystem.Infrastructure.Data;

namespace LibraryManagementSystem.Infrastructure.Repositories
{
    public class AuthorRepository
    {
        private readonly LibraryDbContext _context;
        public AuthorRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public void AddAuthor(Author author) => _context.Authors.Add(author);
        public Author? GetById(int id) => _context.Authors.Find(id);
        public IEnumerable<Author> GetAll() => _context.Authors.ToList();
    }
}
