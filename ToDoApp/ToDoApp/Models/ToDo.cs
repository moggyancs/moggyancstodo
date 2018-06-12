using System;
using System.Collections.Generic;

namespace ToDoApp.Models
{
    public class ToDo
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public User Owner { get; set; }
        public List<User> Contributors { get; set; }
        public Field Field { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }



    }
}
