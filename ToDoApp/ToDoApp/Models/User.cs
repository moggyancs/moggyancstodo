﻿using System;
using System.Collections.Generic;

namespace ToDoApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ToDo> OwnerOfTodos { get; set; }
        public List<ToDo> ContributorOfTodos { get; set; }
        public Role Role { get; set; }
        public DateTime Birthday { get; set; }
        public string PictureSource { get; set; }

    }
}
