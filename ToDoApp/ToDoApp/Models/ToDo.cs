namespace ToDoApp.Models
{
    public class ToDo
    {
        private int id;
        private string title;
        private bool isUrgent;
        private bool isDone;

        public ToDo(string title, bool isUrgent)
        {
            this.Title = title;
            this.IsUrgent = isUrgent;
            this.IsDone = false;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public bool IsUrgent { get => isUrgent; set => isUrgent = value; }
        public bool IsDone { get => isDone; set => isDone = value; }
    }
}
