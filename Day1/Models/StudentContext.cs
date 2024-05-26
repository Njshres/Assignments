using Microsoft.EntityFrameworkCore;

namespace Student_Management.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) 
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
