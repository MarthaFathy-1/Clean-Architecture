using LibraryManagementSystem.Domain.Interfaces;
using LibraryManagementSystem.Infrastructure.Data;

namespace LibraryManagementSystem.Infrastructure.UnitOfWork
{
    public class unitOfWork : IUnitOfWork
    {
        private readonly LibraryDbContext _context;
        public IBookRepository Books { get; }

        public IAuthorRepository Authors { get; }

        public unitOfWork(LibraryDbContext context, IBookRepository bookRepository)
        {
            _context = context;
            Books = bookRepository;
        }
        public unitOfWork(LibraryDbContext context, IAuthorRepository authorRepository)
        {
            _context = context;
            Authors = authorRepository;
        }

        public int Complete() => _context.SaveChanges();
        public void Dispose() => _context.Dispose();
    }
}
