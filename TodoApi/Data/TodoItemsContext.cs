using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Data
{
    public class TodoItemsContext : DbContext
    {
        public TodoItemsContext(DbContextOptions<TodoItemsContext> options):base(options)
        {
            
        }

        public DbSet<TodoItem> TodoItems {get; set;}
    }
}