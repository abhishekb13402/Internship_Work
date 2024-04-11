using Microsoft.EntityFrameworkCore;
using Mini_Project.Models;

namespace Mini_Project.Data
{
    public class AppConfigDBContext : DbContext
    {
        public AppConfigDBContext(DbContextOptions<AppConfigDBContext> options ) : base( options ) 
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TodoTask> TodoTasks { get; set; }
    }
}
