namespace TodoApp.Models
{
    public class Task
    {
        public int task_id { get; set; }
        public int user_id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }

}
