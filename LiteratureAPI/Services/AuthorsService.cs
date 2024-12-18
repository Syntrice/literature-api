using LiteratureAPI.Models;

namespace LiteratureAPI.Services
{
    public class AuthorsService
    {
        private AuthorsModel _model;

        public AuthorsService(AuthorsModel model)
        {
            _model = model;
        }

        public List<Author> GetAllAuthors()
        {
            return _model.GetAuthors();
        }
    }
}
