﻿using System.Collections.Generic;
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
            return context.ToDos.Single(c => c.Id == id);
        }

        public void Update(long id)
        {
            ToDo thingToUpdate = context.ToDos.FirstOrDefault(c => c.Id == 1);
            context.Update(thingToUpdate);
            context.SaveChanges();
        }
    }
}
