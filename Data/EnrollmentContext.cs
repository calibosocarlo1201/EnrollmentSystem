using EnrollmentSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnrollmentSystem.Data
{
    public class EnrollmentContext : DbContext
    {

        public EnrollmentContext(DbContextOptions<EnrollmentContext> options) : base(options)
        {
            
        }

        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<StudentSubjects> StudentSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentSubjects>().HasKey(ss => ss.StudentSubjectID);

            modelBuilder.Entity<StudentSubjects>()
                .HasOne(ss => ss.Students)
                .WithMany(ss => ss.StudentSubjects)
                .HasForeignKey(ss => ss.StudentID);

            modelBuilder.Entity<StudentSubjects>()
                .HasOne(ss => ss.Subjects)
                .WithMany()
                .HasForeignKey(ss => ss.SubjectID);

        }

    }
}
