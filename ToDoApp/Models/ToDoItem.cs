using Microsoft.EntityFrameworkCore;


namespace ToDoApp.Models
{
    public class ToDoItem:DbContext
    {
        public ToDoItem(DbContextOptions<ToDoItem> options) : base(options)
        {
        }

        public DbSet<ToDo> ToDos { get; set; }
    }
}
