using System.Text.Json;

namespace LiteratureAPI.Models
{
    public class AuthorsModel
    {
        public List<Author> GetAuthors()
        {
            return JsonSerializer.Deserialize<List<Author>>(File.ReadAllText("Resources\\Authors.json"));
        }
    }
}
