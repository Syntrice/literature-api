using System.Collections.Generic;
using System.Text.Json;

namespace LiteratureAPI.Models
{
    public class AuthorsModel
    {
        // TODO: don't hard code this, pass in config...?
        private static string DbPath = "Resources/Authors.json";
        private int _nextId;

        public List<Author> Authors
        {
            get
            {
                return Deserialize(DbPath);
            }
        }

        public AuthorsModel()
        {
            List<Author> authors = Deserialize(DbPath);
            _nextId = authors.Select(x => x.Id).Max() + 1;
        }

        public void Append(Author author)
        {
            List<Author> authors = Deserialize(DbPath);
            authors.Add(author);
            Serialize(DbPath, authors);

            author.Id = _nextId++;
        }

        public void Remove(int id)
        {
            List<Author> authors = Deserialize(DbPath);
            Author? authorToRemove = authors.FirstOrDefault(obj => obj.Id == id);
            if (authorToRemove != null)
            {
                authors.Remove(authorToRemove);
                Serialize(DbPath, authors);
            }
        }

        private void Serialize(string path, List<Author> authors)
        {
            File.WriteAllText(path, JsonSerializer.Serialize(authors, new JsonSerializerOptions { WriteIndented = true }));
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
