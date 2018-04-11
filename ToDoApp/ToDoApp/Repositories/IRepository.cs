using System.Collections.Generic;
using ToDoApp.Models;

namespace ToDoApp
{
    public interface IRepository
    {
        void Create(ToDo thing);
        List<ToDo> Read();
        void Update(long id);
        void Delete(long id);
    }
}