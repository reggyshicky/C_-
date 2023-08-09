using Microsoft.EntityFrameworkCore;

namespace WebAPI_Test
{
    public class SchoolDBContext:DbContext
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options):
            base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; } 
    }
}
