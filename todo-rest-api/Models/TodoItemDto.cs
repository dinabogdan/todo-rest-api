using System;
namespace todo_rest_api.Models
{
    public class TodoItemDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
