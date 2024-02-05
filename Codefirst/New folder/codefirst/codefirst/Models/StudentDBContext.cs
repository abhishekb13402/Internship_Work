using Microsoft.EntityFrameworkCore;

namespace codefirst.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
