using Microsoft.EntityFrameworkCore;
using Relationship.Models;

namespace Relationship.Data
{
    public class ApplicationDBContext:DbContext

    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<EmployeeDetails>EmployeeDetails { get; set; }
        public DbSet<Manager> managers { get; set; }
     
    }
}
