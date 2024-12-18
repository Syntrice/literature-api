namespace LiteratureAPI.Models
{
    public class Book : IData
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int Year {  get; set; }
    }
}