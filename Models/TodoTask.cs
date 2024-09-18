using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class TodoTask
    {
        public int TaskId  { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }

}
