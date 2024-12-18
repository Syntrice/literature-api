using System.Text.Json;

namespace LiteratureAPI.Models
{
    public class AuthorsModel
    {
        public List<Author> FetchAuthors()
        {
            var deserializedData = JsonSerializer.Deserialize<List<Author>>(File.ReadAllText("Resources\\Authors.json"));

            if (deserializedData == null )
            {
                return [];
            }
            else
            {
                return deserializedData;
            }
        }
    }
}
