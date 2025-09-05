using LibraryManagementSystem.Domain.Interfaces;

namespace LibraryManagementSystem.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        IAuthorRepository Authors { get; }
        int Complete();
    }
}
