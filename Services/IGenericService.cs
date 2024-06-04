
namespace Services
{
    public interface IService<T>
    {
        void Create(T item);
        T? Read(int id);
        IEnumerable<T> Read();
        bool Update(int id, T item);
        bool Delete(int id);
    }
}
