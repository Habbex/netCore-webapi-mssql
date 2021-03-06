using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoApi.Data;

namespace TodoApi.Models
{
    public static class SeedData
    {
        public static void Initalize(IServiceProvider serviceProvider)
        {
            using (var context = new TodoItemsContext(serviceProvider.GetRequiredService<DbContextOptions<TodoItemsContext>>()))
            {
                if (context.TodoItems.Any())
                {
                    return; // DB is already seeded.
                }

                context.TodoItems.AddRange(
                    new TodoItem
                    {
                        Id= 1,
                        Name= "Do laundry",
                        IsComplete= false,
                    },
                       new TodoItem
                    {
                        Id= 2,
                        Name= "Cook food",
                        IsComplete= true,
                    },
                       new TodoItem
                    {
                        Id= 3,
                        Name= "Clean home",
                        IsComplete= false,
                    } 
                );
                context.SaveChanges();
            }
        }
    }
}