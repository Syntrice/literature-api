using LiteratureAPI.Models;

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
            return _model.Authors;
        }

        public void AddAuthor(Author author)
        {
            _model.Append(author);
        }

        public void RemoveAuthorById(int id)
        {
            _model.Remove(id);
        }
    }
}
