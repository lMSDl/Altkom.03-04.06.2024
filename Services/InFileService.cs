using Models;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace Services
{
    public class InFileService : InMemoryService
    {
        public InFileService()
        {
            Load();
        }

        /*public override void Create(ToDoItem item)
        {
            base.Create(item);
            Save();
        }

        public override bool Delete(int id)
        {
            bool result = base.Delete(id);
            if (result == true)
            {
                Save();
            }

            return result;
        }

        public override bool Update(int id, ToDoItem item)
        {
            bool result = base.Update(id, item);
            if (result == true)
            {
                Save();
            }

            return result;
        }*/

        public override bool ChangeIsCompleted(int id)
        {
            bool result = base.ChangeIsCompleted(id);
            if (result == true)
            {
                Save();
            }

            return result;
        }


        private void Save()
        {
            string json = JsonSerializer.Serialize(_items);
            File.WriteAllText("data.json", json);
        }


        private void Load()
        {
            IEnumerable<ToDoItem> items;
            if (File.Exists("data.json"))
            {
                string json = File.ReadAllText("data.json");
                items = JsonSerializer.Deserialize<IEnumerable<ToDoItem>>(json)!;
            }
            else
            {
                items = [];
            }
            var observableItems = new ObservableCollection<ToDoItem>(items);
            observableItems.CollectionChanged += (sender, args) => Save();
            
            _items = observableItems;
        }
    }
}
