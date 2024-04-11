using AutoMapperExample.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperExample.DBContext
{
    public class AppConfigDBContext : DbContext
    {
        public AppConfigDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<User> users { get; set; }
    }
}
