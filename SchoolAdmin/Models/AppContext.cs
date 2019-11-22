using System.Data.Entity;

namespace SchoolAdmin.Models
{
    public class CourseAppContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

    }

    public class StudentAppContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}