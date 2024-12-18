using System.Text.Json;

namespace LiteratureAPI.Models
{
    public class AuthorsModel
    {
        // TODO: don't hard code this, pass in config...?
        private static string DbPath = "Resources/Authors.json";
        private int _nextId;

        public AuthorsModel()
        {
            List<Author> authorList = Deserialize(DbPath);
            _nextId = authorList.Select(x => x.Id).Max() + 1;
        }

        public List<Author> GetAuthors()
        {
            return Deserialize(DbPath);
        }

        public void AddAuthor(Author author)
        {
            author.Id = _nextId++;
            Append(DbPath, author);
        }

        private void Append(string path, Author author)
        {
            List<Author> list = Deserialize(path);
            list.Add(author);
            File.WriteAllText(path, JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true }));
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
