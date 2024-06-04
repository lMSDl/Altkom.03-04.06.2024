using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IService
    {
        void Create(ToDoItem item);
        ToDoItem? Read(int id);
        IEnumerable<ToDoItem> Read();
        bool Update(int id, ToDoItem item);
        bool Delete(int id);
        bool ChangeIsCompleted(int id);
    }
}
