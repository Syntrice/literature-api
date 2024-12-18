using System.Collections.Generic;
using System.Text.Json;

namespace LiteratureAPI.Models
{
    public class AuthorsModel : JSONDataModel<Author>
    {
        // TODO: use options pattern to pass in path, rather than hardcoding
        private const string Path = "Resources\\Authors.json";

        public AuthorsModel() : base(Path)
        {
        }
    }
}
