using Microsoft.EntityFrameworkCore;

namespace FirstResponsiveWebAppAdolfson.Models
{
    public class StudentContext : DbContext
    {

        public StudentContext() { }

        public StudentContext (DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(

                new Student
                {
                    StudentId = 1,
                    FirstName = "Antony",
                    LastName = "Adolfson",
                    Grade = 80
                },

                new Student
                {
                    StudentId = 2,
                    FirstName = "Nicolas",
                    LastName = "Adolfson",
                    Grade = 90
                },

                new Student
                {
                    StudentId = 3,
                    FirstName = "Joshua",
                    LastName = "Adolfson",
                    Grade = 95
                }

                ); ;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Students;Integrated Security=true;MultipleActiveResultSets=true");
        }

    }
}
