using System.Collections.Generic;

namespace ToDoApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ToDo> ToDos { get; set; }
        public bool IsAdmin { get; set; }
        public string PictureSource { get; set; }

        public User(string name)
        {
            Name = name;
            IsAdmin = false;
        }

        public User()
        {
            IsAdmin = false;
        }
    }
}
