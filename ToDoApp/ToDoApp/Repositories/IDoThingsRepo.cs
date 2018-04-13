using System.Collections.Generic;
using ToDoApp.Models;

namespace ToDoApp.Repositories
{
    public interface IDoThingsRepo
    {
        void Create(ToDo thing);
        List<ToDo> Read();
        void Update(long id);
        void Delete(long id);
        ToDo ShowToDo(long id);

        void AddUser(User user);
        IEnumerable<User> GetUsers();
        User ShowUser(int id);
        void DeleteUser(int id);
    }
}
