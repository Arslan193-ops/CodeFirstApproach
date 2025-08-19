using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions Options) :base(Options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
