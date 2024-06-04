using Models;

namespace Services
{
    public class InMemoryService
    {
        private readonly ICollection<ToDoItem> _items = [];

        public void Create(ToDoItem item)
        {
            int maxId = 0;

            foreach (ToDoItem toDoItem in _items)
            {
                if (maxId <= toDoItem.Id)
                {
                    maxId = toDoItem.Id;
                }
            }
            item.Id = maxId + 1;

            _items.Add(item);
        }

        public ToDoItem? Read(int id)
        {
            foreach (ToDoItem toDoItem in _items)
            {
                if (id == toDoItem.Id)
                {
                    return toDoItem;
                }
            }
            return null;
        }

        public IEnumerable<ToDoItem> Read()
        {
            //konstruktor kopiujący
            return new List<ToDoItem>(_items);
        }

        public bool Update(int id, ToDoItem item)
        {
            if (!Delete(id))
            {
                return false;
            }

            item.Id = id;
            _items.Add(item);
            return true;
        }

        public bool Delete(int id)
        {
            ToDoItem? item = Read(id);
            if (item == null)
            {
                return false;
            }

            _ = _items.Remove(item);
            return true;
        }

        public bool ChangeIsCompleted(int id)
        {
            ToDoItem? item = Read(id);
            if (item == null)
            {
                return false;
            }

            item.IsCompleted = !item.IsCompleted;
            return true;
        }
    }
}
