using Microsoft.EntityFrameworkCore;
using ToDoGrpc.Models;

namespace ToDoApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ToDoItem> ToDoItems => Set<ToDoItem>();
    }
}
