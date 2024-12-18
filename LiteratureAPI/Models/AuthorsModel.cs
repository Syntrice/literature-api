using System.Text.Json;

namespace LiteratureAPI.Models
{
    public class AuthorsModel
    {
        // TODO: don't hard code this, pass in config...?
        private static string DbPath = "Resources/Authors.json";

        public List<Author> Authors { get; }

        public AuthorsModel()
        {
            Authors = Deserialize(DbPath);
        }

        private List<Author> Deserialize(string path)
        {
            var deserializedData = JsonSerializer.Deserialize<List<Author>>(File.ReadAllText("Resources\\Authors.json"));
            if (deserializedData == null)
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
