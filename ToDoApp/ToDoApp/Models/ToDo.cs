namespace ToDoApp.Models
{
    public class ToDo
    {
        private long id;
        private string title;
        private bool isUrgent;
        private bool isDone;
        private string description;
        private User user;

        public ToDo()
        {
        }

        public ToDo(string title, bool isUrgent)
        {
            this.Title = title;
            this.IsUrgent = isUrgent;
            this.IsDone = false;
            this.Description = "";
        }

        public long Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public bool IsUrgent { get => isUrgent; set => isUrgent = value; }
        public bool IsDone { get => isDone; set => isDone = value; }
        public string Description { get => description; set => description = value; }
        public User User { get => user; set => user = value; }
    }
}
