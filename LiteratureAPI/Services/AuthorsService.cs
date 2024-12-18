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
            return _model.FetchAuthors();
        }
    }
}
