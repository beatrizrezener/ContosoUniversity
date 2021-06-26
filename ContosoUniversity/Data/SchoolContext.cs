using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    // The main class that coordinates Entity Framework functionality for a given data model is the database context class
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }
        // In EF terminology, an entity set typically corresponds to a database table,
        // and an entity corresponds to a row in the table.
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        // DbSet<Enrollment> and DbSet<Course> could've omitted and it would work the same.
        // The EF would include them implicitly because the Student entity references the
        // Enrollment entity and the Enrollment entity references the Course entity.
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}