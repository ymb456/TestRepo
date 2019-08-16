using WebApplication8.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication8.Data
{
    public class SchooTestContext : DbContext
    {
        public SchooTestContext(DbContextOptions<SchooTestContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}