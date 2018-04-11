namespace ToDoApp.Models
{
    public class ToDo
    {
        private long id;
        private string title;
        private bool isUrgent;
        private bool isDone;

        public ToDo(string title, bool isUrgent)
        {
            this.title = title;
            this.isUrgent = isUrgent;
            this.isDone = false;
        }
    }
}
