using LibraryManagementSystem.Domain.Interfaces;
using LibraryManagementSystem.Domain.Models;

namespace LibraryManagementSystem.Application.Services
{
    public class AddAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        public AddAuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public void Execute(string name)
        {
            var author = new Author { Name = name };
            _authorRepository.AddAuthor(author);
        }
    }
}
