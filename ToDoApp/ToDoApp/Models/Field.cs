using System.Collections.Generic;

namespace ToDoApp.Models
{
    public class Field
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ToDo> ToDosOfField { get; set; }
    }
}
