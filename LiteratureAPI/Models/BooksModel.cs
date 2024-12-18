namespace LiteratureAPI.Models
{
    public class BooksModel : JSONDataModel<Book>
    {

        // TODO: use options pattern to pass in path, rather than hardcoding
        private const string Path = "Resources\\Books.json";

        public BooksModel() : base(Path)
        {
        }
    }
}
