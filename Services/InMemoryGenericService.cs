using Models;

namespace Services
{
    public class InMemoryService<T> : IService<T> where T : Entity
    {
        protected ICollection<T> _items = [];

        public virtual void Create(T item)
        {
            item.Id = _items.Select(item => item.Id).DefaultIfEmpty(0).Max() + 1;

            _items.Add(item);
        }

        public T? Read(int id)
        {
            return _items.Where(x => x.Id == id).SingleOrDefault();
        }

        public IEnumerable<T> Read()
        {
            return new List<T>(_items);
        }

        public virtual bool Update(int id, T item)
        {
            if (!Delete(id))
            {
                return false;
            }

            item.Id = id;
            _items.Add(item);
            return true;
        }

        public virtual bool Delete(int id)
        {
            T? item = Read(id);
            if (item == null)
            {
                return false;
            }

            _ = _items.Remove(item);
            return true;
        }

    }
}
