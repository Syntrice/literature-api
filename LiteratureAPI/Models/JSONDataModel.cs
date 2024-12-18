using System.Runtime.Remoting;
using System.Text.Json;

namespace LiteratureAPI.Models
{
    public class JSONDataModel<T> where T : IData
    {
        private int _nextId;
        private readonly string _path;

        public List<T> Data
        {
            get
            {
                return Deserialize();
            }
        }

        public JSONDataModel(string jsonPath)
        {
            _path = jsonPath;
            List<T> data = Deserialize();
            _nextId = data.Select(x => x.Id).Max() + 1;
        }

        public void Append(T obj)
        {
            obj.Id = _nextId++;
            List<T> data = Deserialize();
            data.Add(obj);
            Serialize(data);
        }

        public void Remove(int id)
        {
            List<T> data = Deserialize();
            T? objToRemove = data.FirstOrDefault(obj => obj.Id == id);
            if (objToRemove != null)
            {
                data.Remove(objToRemove);
                Serialize(data);
            }
        }

        private void Serialize(List<T> data)
        {
            File.WriteAllText(_path, JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true }));
        }

        private List<T> Deserialize()
        {
            var deserializedData = JsonSerializer.Deserialize<List<T>>(File.ReadAllText(_path));
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
