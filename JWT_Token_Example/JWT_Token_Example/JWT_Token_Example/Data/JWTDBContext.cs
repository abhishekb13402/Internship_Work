using Microsoft.EntityFrameworkCore;

namespace JWT_Token_Example.Data
{
    public class JWTDBContext : DbContext
    {
        public JWTDBContext(DbContextOptions options):base(options)
        {
            
        }

    }
}
