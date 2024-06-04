using Models;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace Services
{
    public class InFileService<T> : InMemoryService<T> where T : Entity
    {
        public InFileService()
        {
            Load();
        }

        private void Save()
        {
            string json = JsonSerializer.Serialize(_items);
            File.WriteAllText("data.json", json);
        }


        private void Load()
        {
            IEnumerable<T> items;
            if (File.Exists("data.json"))
            {
                string json = File.ReadAllText("data.json");
                items = JsonSerializer.Deserialize<IEnumerable<T>>(json)!;
            }
            else
            {
                items = [];
            }
            var observableItems = new ObservableCollection<T>(items);
            observableItems.CollectionChanged += (sender, args) => Save();
            
            _items = observableItems;
        }
    }
}
