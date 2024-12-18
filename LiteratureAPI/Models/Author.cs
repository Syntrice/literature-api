namespace LiteratureAPI.Models
{
    public class Author : IData
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Nationality { get; set; } = null!;
    }
}
