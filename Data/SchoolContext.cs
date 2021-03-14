///////////////////////////////////////////////////////////
// Date         Developer    Description
// 2021-03-11   Chase H.     Created intial file for ContosoUniversity
// 2021-03-12   Chase H.     Created SchoolContext program
// 2021-03-13   Chase H.     Finished SchoolContext program
//
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    //tinfo200:[2021-03-13-1972039-dykstra1] Set up SchoolContext class to make sure the database uses Courses,
    //Enrollments and Students variables
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //tinfo200:[2021-03-13-1972039-dykstra1] Tells the entity framework, what names we want it to display on the page
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}