using Microsoft.AspNetCore.SignalR;

namespace ToDoApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }

    }
}