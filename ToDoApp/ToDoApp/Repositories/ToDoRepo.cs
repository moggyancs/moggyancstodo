using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.Models;

namespace ToDoApp.Repositories
{
    public class ToDoRepo : IDoThingsRepo
    {
        ToDoContext context;

        public ToDoRepo(ToDoContext context)
        {
            this.context = context;
        }

        public void AddUser(User user)
        {
            context.Add(user);
            context.SaveChanges();
        }

        public IEnumerable<User> GetUsers()
        {
            return context.Users;
        }

        public void Create(ToDo thing)
        {
            context.Add(thing);
            context.SaveChanges();
        }

        public void Delete(long id)
        {
            ToDo thing = context.ToDos.Single(c => c.Id == id);
            context.Remove(thing);
            context.SaveChanges();
        }

        public List<ToDo> Read()
        {
            return context.ToDos.ToList();
        }

        public ToDo ShowToDo(long id)
        {
            context.Users.Load();
            return context.ToDos.Single(c => c.Id == id);
        }

        public void Update(long id)
        {
            ToDo thingToUpdate = context.ToDos.FirstOrDefault(c => c.Id == 1);
            context.Update(thingToUpdate);
            context.SaveChanges();
        }

        public User ShowUser(int id)
        {
            context.ToDos.Load();
            return context.Users.Single(c => c.Id == id);
        }
    }
}
