using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class Task
    {
        public int TaskId  { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }

}
