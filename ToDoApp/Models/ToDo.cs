using System;

namespace ToDoApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public Status Status { get; set; }
        public DateTime Deadline { get; set; }
    }
    public enum Status
    {
        notStarted,
        processing,
        pass,     
    }
}
