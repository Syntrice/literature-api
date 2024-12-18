using LiteratureAPI.Models;

namespace LiteratureAPI.Services
{
    public class BooksService
    {
        private readonly BooksModel _model;

        public BooksService(BooksModel model)
        {
            _model = model;
        }

        public List<Book> GetBooks()
        {
            return _model.Data;
        }

        public void AddBook(Book book)
        {
            _model.Append(book);
        }

        public void RemoveBookById(int id)
        {
            _model.Remove(id);
        }
    }
}
