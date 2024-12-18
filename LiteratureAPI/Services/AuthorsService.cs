using LiteratureAPI.Models;
using System.Text.Json;

namespace LiteratureAPI.Services
{
    public class AuthorsService
    {
        private readonly AuthorsModel _model;

        public AuthorsService(AuthorsModel model)
        {
            _model = model;
        }

        public List<Author> GetAuthors()
        {
            return _model.GetAuthors();
        }

        public void AddAuthor(Author author)
        {
            _model.AddAuthor(author);
        }
    }
}
