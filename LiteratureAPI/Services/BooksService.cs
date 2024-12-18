using LiteratureAPI.Models;
using System.Threading.Tasks.Dataflow;

namespace LiteratureAPI.Services
{
    public class BooksService
    {
        private readonly BooksModel _booksModel;
        private readonly AuthorsModel _authorsModel;

        public BooksService(BooksModel booksModel, AuthorsModel authorsModel)
        {
            _booksModel = booksModel;
            _authorsModel = authorsModel;
        }

        public List<Book> GetBooks()
        {
            return _booksModel.Data;
        }

        public List<Book> GetBooksByAuthorId(int id)
        {
            var books = from book in _booksModel.Data
                        join author in _authorsModel.Data
                        on book.Author equals author.Name
                        where author.Id == id
                        select book;

            return books.ToList();
        }

        public void AddBook(Book book)
        {
            _booksModel.Append(book);
        }

        public void RemoveBookById(int id)
        {
            _booksModel.Remove(id);
        }
    }
}
