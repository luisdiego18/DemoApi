using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;


namespace DemoApi.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base (options)
        {
        }

        public DbSet<TodoItem> TodoItems {get; set;} = null!;
    }
}