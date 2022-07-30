using _1_ToDo.Models;
using Microsoft.EntityFrameworkCore;

namespace _1_ToDo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ToDoModel> ToDos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
            => options.UseSqlite("DataSource=app.db;Cache:Shared");

    }
}
