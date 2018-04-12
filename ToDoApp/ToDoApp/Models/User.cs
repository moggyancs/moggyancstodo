using System.Collections.Generic;

namespace ToDoApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }
        public List<ToDo> ToDos { get; set; }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}
