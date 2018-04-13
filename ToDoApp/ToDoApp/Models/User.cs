using System.Collections.Generic;

namespace ToDoApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ToDo> ToDos { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
